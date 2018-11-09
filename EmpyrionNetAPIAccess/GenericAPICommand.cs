using Eleon.Modding;
using System;
using EmpyrionNetAPIDefinitions;
using System.Threading;

namespace EmpyrionNetAPIAccess
{
  [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable")]
  public class UnhandledGameAPIError : Exception {
        public UnhandledGameAPIError(string message) : base(message) { }
    }


    public class GenericAPICommand
    {
        private static Random  rnd = new Random();

        public APIRequest call;
        public object argument;
        public Action<CmdId, object> responseHandler;
        public Action<ErrorInfo> errorHandler;
        public bool validated;
        
        public ushort SequenceNumber
        {
            get
            {
                var argPart = argument == null ? 1 : argument.GetHashCode() % 511;
                var cmdIdPart = (ushort)call.CmdId + 1;
                var combined = (cmdIdPart << 7) | argPart;
                return (ushort)combined;
            }
        }

        private void defaultResponseHandler(CmdId evt, object data)
        {
            //log(() => $"unhandled response to {evt} event with {data}");
        }

        private void defaultErrorHandler(ErrorInfo err)
        {
            throw new UnhandledGameAPIError($"{err.errorType} : {err.ToString()}");
        }

        public GenericAPICommand(CmdId cmdId, object argument, Action<CmdId, object> responseHandler=null, Action<ErrorInfo> errorHandler=null, bool validate = false)
        {

            this.call = APIManifest.APIRequestTable[cmdId];
            this.argument = argument;
            this.responseHandler = responseHandler ?? defaultResponseHandler;
            this.errorHandler = errorHandler ?? defaultErrorHandler;
            this.validated = validate ? validateArguments(this.call, this.argument, this.responseHandler) : validate;
        }

        private static bool validateArguments(APIRequest call, object argument, Action<CmdId, object> responseHandler)
        {
            var argType = argument != null ? argument.GetType() : null;
            string message = null;
            if (argType != call.ParamType)
            {
                message = $"{argType.ToString()} is not a valid argument type for API call {call.CmdId}; expected: {call.ParamType.Name} ";
            }
            if (message != null)
            {
                throw new ArgumentException(message);
            }
            return true;
        }
    
    }
}
