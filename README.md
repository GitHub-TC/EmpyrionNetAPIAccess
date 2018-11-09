# EmpyrionAPITools

## FAQ

### What is this?

Right now, writing mods with the Empyrion API is really difficult, so I created a framework that takes a way a lot of the plumbing, and replaces it with an API that uses the C# type system to help you tp write mods.

### How does it work?

The base mod API has two critical concepts, requests and events.  

#### Events

Events are messages that the server sends to the mod through the Game_Event method.  Each method call comes with 3 arguments:
```csharp
void ModInterface.Game_Event(CmdId eventId, ushort seqNr, object data)
```

Let's look at the "Playfield Load" event.  This if fired every time that a new player moves into a previously unloaded playfield.
(a list of CmdIds can be found here: https://empyrion.gamepedia.com/Game_API_CmdId#Request_Blueprint_Resources)

```CmdId eventId``` is the "type" of the event, in this case the value is, "Event_Playfield_Loaded"

```ushort seqNr``` will be 0 in this case, and for all events that aren't fired in response to requests (more on that later)

```object data``` will be a ```PlayfieldLoad``` object, that you can inspect ot find out information about the event.

Because of the nature of the API, using enum CmdId means that you don't know the actual type of the `data` until you've received the CmdId, this means that the type system can't be used to reason about what you receive, meaning that you can't use intellisense, or typechacking to verify that your code will work ahead of time.  This mod takes all that away by offering native C# event management for game generated events.  Where before to interpret a chat event you would have to write a lot of infrastructure, for example:

```csharp
void ModInterface.Game_Event(CmdId eventId, ushort seqNr, object data)
{
  if(eventId == CmdId.Event_ChatMessage)
  {
    var chatInfo = (ChatInfo)data;
    if (chatInfo.msg.Contains("hello"))
    {
      //do something
    }
  }
}
```

With this repo, you can you use a ```SimpleMod``` and it looks like this:

```csharp
this.Event_ChatMessage += (chatInfo) =>
{
  //do something with chatInfo
};
```

if you wanted to make it a little easier to read, you could also do this:

```csharp

this.Event_ChatMessage += ExampleMod_Event_ChatMessage;

private void ExampleMod_Event_ChatMessage(ChatInfo chatInfo)
{
    //do something with chatInfo
}
```

Which is a lot easier to work with.

#### Requests

The other key concept is Requests, which are sent to the game using the API.  When you submit a request to the server, you use do it useing ```ModGameAPI```'s ```Game_Request``` method, whose prototype looks like this:
```csharp
bool Game_Request(CmdId reqId, ushort seqNr, object data)
```

Notice how it looks like the prototype for ```Game_Event```?  When you submit a request to the server, you do it with a ```CmdId```, that describes the type of request that you're submitting, along with an appropriately typed ```object``` that will act as a parmeter, and a ```seqNr``` that acts as an identifier for your request.  When the server is finished processing your request, it will fire a ```Game_Event``` with the response to your request, but identify it with the appropriate ```seqNr```.  Let's look at an example

Let's say we want to get the ```PlayerInfo``` for the player with EntityId 23.  Using the old method, it would look something like this:

```csharp

dediAPI.Game_Request(CmdId.Request_Player_Info, 31, new Id(23))

void ModInterface.Game_Event(CmdId eventId, ushort seqNr, object data)
{
	if(eventId == CmdId.Event_Player_Info && seqNr == 31)
	{
		var info = (PlayerInfo)data;
		//do something with info for player 23
	}
}

```

That might not look too bad, but it's pretty hard to mantain as you scale up the number of requests.  Using a `SimpleMod`, you can accomplish the same thing by using a call like this:

```csharp
this.Request_Player_Info(new Id(23), (info) =>
{
	//do something with info
});
```

#### Errors

If you've worked with the API before, you might be wondering, "how do I track the errors that might be returned as part of my request?"  Please note that all request methods accept an optional `errorHandler` method, that will be fired if an error is returned for the specified request along with it's assoociated ```ErrorInfo```.  For Example:

```csharp
this.Request_Player_Info(new Id(-230), (info) =>
{
	//do somehthing with info
}, (err) =>
{
	// do something with err
});
```

### How do I use it?

In principle, using the framework is very simple, and it has 4 steps:

1. Create a new .NET 3.5 Class Library
2. Add references to dlls
3. Implement a class that inherits from `SimpleMod`
4. Bundle using ILMerge
5. Deploy to server

#### Import References

There are two DLLs that you'll need to get started, they are:

* `EmpyrionAPITools\build\EmpyrionAPITools\EmpyrionAPITools.dll`
* `EmpyrionAPITools\build\EmpyrionAPITools\EmpyrionAPIDefinitions.dll`

Make sure that you add references to both of them in your new project.  Make sure that in the properties menu for each reference, "Copy Local" is set to true.

*Note: In the future these might be compressed to a single dll, but for now there will be two*

#### Implement a `SimpleMod`

Create a new class that inherits from ```SimpleMod```.  It will require you to implement an `Initialize` method, which is where you'll initialize your mod.  For Example:

```csharp
using Eleon.Modding;
using EmpyrionAPITools;

namespace ExampleMod
{
  class Example : SimpleMod
  {
    public override void Initialize(ModGameAPI dediAPI)
    {
      this.Event_Player_Connected += Example_Event_Player_Connected;
    }

    private void Example_Event_Player_Connected(Id obj)
    {
      var msg = new IdMsgPrio()
      {
        msg = $"player: {obj.id} has connected. Welcome!"
      };
      this.Request_InGameMessage_AllPlayers(msg);
    }
  }
}
```

Note that all this mod does is listen for `Plyer_Connected` events, and when they are received, it fires a message to all clients on the server.

#### Bundle using IlMerge and Deploy

In order to deploy this to your server, you'll need a single DLL artifact that contains all of the dependencies.  THe easiest way to do this, that I've found is to use the ilmerge msbuild task (found on nuget as MSBuild.ILMerge.Task or here https://archive.codeplex.com/?p=ilmergemsbuild ).

In order to use it, just install the plugin using nuget, and your build artifact will be bundled appropriately.

This will produce a single DLL, that you can copy into a folder on your server in the `Content/Mods` folder.  For example

* `Content/Mods`
  * `Content/Mods/Example`
    * `Content/Mods/Example/Example.dll`

Note that you must restart the server in order for the mod to be loaded.

### What is a ChatCommand?

The `ChatCommands` API is a way of describing functions that can be invoked with text entry to the chat box (using the "." in-game).

The basic usage looks like this:

```csharp

this.ChatCommands.Add(new ChatCommand(@"loudly (?<yellthis>.+)", (data, args) => {
  var msg = new IdMsgPrio()
  {
    id = data.playerId,
    msg = $"{args["yellthis"].ToUpper()}!!!!!"
  };
  this.Request_InGameMessage_SinglePlayer(msg);
}));

```

In this example, there is a call made in the `Initialize` function of our mod that is adding to the `ChatCommands` collection, inherited from `SimpleMod`

The constructor for `ChatCommand` takes two arguments, a regex pattern as a string.  In this case, the pattern is, `"@"loudly (?<yellthis>.+)""` which, matches phrases like, "loudly he went to the store".  Note that in this case, "loudly " would be matched by the concrete part of the pattern, whereas "he went to the store" would be captured as part of the named capture group, "yellthis".

Next we specify a handler for the ChatCommand, which is a function that returns `void`, and accepts two arguments, a `ChatInfo` object from the `Eleon.Modding` namespace and a `Dictionary<String, String>`.  The `ChatInfo` for the the chat message event is passed in this case as the variable `data`, The dictionary, `args` will contain all of the named capture groups.  In this case, the dictionary will have only 1 key value pair: `"yellthis": "he went to the store"`

#### Is this API final?

Oh god no!  If you have a better way I'd be thrilled to integrate it.

### Where are the docs?

This isn't very well documented at the moment, but if it starts seeing traction, I'll document it more throughly.  For now feel free to leave questions in the issue tracker.

### How can I contribute?

Feel free to leave feedback, or submit pull requests.  I'm doing this so that we get more mods for Empyrion, so anything I can do to help enable you, I'd love to know about.

---

**Have Fun!**
