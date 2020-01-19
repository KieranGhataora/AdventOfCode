using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models
{
    public abstract class OpCodeHandler
    {
        public int Code;
        public bool ExitCode;
        public abstract int[] Execute(int[] program, ref int currentPosition, IWriter diagnosticsWriter); 
        
        protected OpCodeHandler(int code, bool exitCode)
        {
            Code = code;
            ExitCode = exitCode;
        }
    }
}