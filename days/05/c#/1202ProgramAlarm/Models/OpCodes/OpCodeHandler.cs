namespace _1202ProgramAlarm.Models
{
    public abstract class OpCodeHandler
    {
        public int Code;
        public bool ExitCode;
        public abstract int[] Execute(int[] program, int currentPosition); 
        
        protected OpCodeHandler(int code, bool exitCode)
        {
            Code = code;
            ExitCode = exitCode;
        }
    }
}