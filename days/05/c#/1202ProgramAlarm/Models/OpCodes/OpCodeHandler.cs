using System.Collections.Generic;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models
{
    public abstract class OpCodeHandler
    {
        public int Code;
        public bool ExitCode;

        public abstract int[] Execute(int[] program, int[] parameterModes, ref int currentPosition,
            IWriter diagnosticsWriter);

        protected OpCodeHandler(int code, bool exitCode)
        {
            Code = code;
            ExitCode = exitCode;
        }

        protected int[] GetParameters(int[] program, int[] parameterModes, int currentPosition, int numberOfParams)
        {
            return new int[]
            {
                parameterModes[0] == 0 ? program[program[currentPosition + 1]] : program[currentPosition + 1],
                parameterModes[1] == 0 ? program[program[currentPosition + 2]] : program[currentPosition + 2],
                parameterModes[2] == 0 ? program[currentPosition + 3] : program[program[currentPosition + 3]]
            };
        }
    }
}