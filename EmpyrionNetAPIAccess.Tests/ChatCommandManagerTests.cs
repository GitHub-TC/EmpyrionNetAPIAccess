using Microsoft.VisualStudio.TestTools.UnitTesting;
using EmpyrionNetAPIAccess;
using System.Collections.Generic;
using System.Linq;
using Eleon.Modding;
using EmpyrionNetAPIDefinitions;
using System.Threading.Tasks;
using System;

namespace EmpyrionNetAPIAccess.Tests
{
  [TestClass]
  public class ChatCommandManagerTests
  {

    ChatCommandManager ccm;
    List<ChatCommand> commandList;
    ChatCommand t1, t2;

    [TestInitialize]
    public void InitTest() {
      t1 = new ChatCommand("test", null);
      t2 = new ChatCommand("test2", null);
      commandList = commandList = new List<ChatCommand>()
      {
        t1,
        t2
      };
      ccm = new ChatCommandManager(commandList);
    }

    [TestMethod]
    public void TestSuperPatternCompilation()
    {    
      Assert.IsTrue(ccm.superPattern.pattern.IsMatch("test"));
      Assert.IsTrue(ccm.superPattern.pattern.IsMatch("test2"));
      Assert.IsFalse(ccm.superPattern.pattern.IsMatch("blah"));
    }

    [TestMethod]
    public void TestCommandMatching()
    {
      var cmd = ccm.MatchCommand("test2");
      Assert.AreSame(cmd.command, t2);
      var cmd2 = ccm.MatchCommand("bleh");
      Assert.IsNull(cmd2);
    }

    [TestMethod]
    public void testCommandWithArg()
    {
      var pattern = @"test (?<name>\S*) is (?<disposition>\S*)";
      var cc = new ChatCommand(pattern, async (x, y) => await TestDummy());
      commandList.Add(cc);
      ccm = new ChatCommandManager(commandList);

      var result = ccm.MatchCommand("test chris is good");
      Assert.AreSame(cc, result.command);

    }

        private Task<Task> TestDummy()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
    public void testPatternToString()
    {
      var pattern = @"test (?<name>\S*) is (?<disposition>\S*)";
      
      var actual = ChatCommand.PatternToParamString(pattern);
      var expected = @"test {name} is {disposition}";
      Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void testCommandsToString()
    {

      var c1 = new ChatCommand(@"test (?<name>\S*) is (?<disposition>\S*)", (_, __) => TestDummy());
      var c2 = new ChatCommand(@"test2 (?<name>\S*) is (?<disposition>\S*)", (_, __) => TestDummy(), "something");
      var c3 = new ChatCommand(@"test3 (?<name>\S*) is (?<disposition>\S*)", (_, __) => TestDummy(), "somethingelse", PermissionType.GameMaster);

      var actuals = new Dictionary<string, string>()
      {
        { c1.ToString(), @"test {name} is {disposition}"},
        { c2.ToString(), @"test2 {name} is {disposition} : something"},
        { c3.ToString(), @"test3 {name} is {disposition} : (GameMaster) somethingelse"},
      };

      foreach (var item in actuals.Keys)
      {
        Assert.AreEqual(item, actuals[item]);
      }

      var ccm2 = new ChatCommandManager(new List<ChatCommand>()
      {
        c1,c2,c3
      });
      
    }

    [TestMethod]
    public void tesMatchCompetition()
    {

      var c1 = new ChatCommand(@"test (?<name>\S*) is (?<disposition>\S*)", (_, __) => TestDummy());
      var c2 = new ChatCommand(@"test2 (?<name>\S*) is (?<disposition>\S*)", (_, __) => TestDummy(), "something");
      var c3 = new ChatCommand(@"test3 (?<name>\S*) is (?<disposition>\S*)", (_, __) => TestDummy(), "somethingelse", PermissionType.GameMaster);

      ccm = new ChatCommandManager(new List<ChatCommand>()
      {
        c1,c2,c3
      });

      var actual = ccm.MatchCommand("test2 chris is happy");
      var expectedName = "chris";
      var expectedDisposition = "happy";

      Assert.AreSame(actual.command, c2);
      Assert.AreEqual(expectedName, actual.parameters["name"]);
      Assert.AreEqual(expectedDisposition, actual.parameters["disposition"]);


    }

  }
}
