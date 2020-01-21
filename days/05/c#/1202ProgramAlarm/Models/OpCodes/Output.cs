using System;
using System.Linq;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class Output: OpCodeHandler
    {
        public Output() : base(4, false)
        {
        }

        public override int[] Execute(int[] program, int[] parameterModes, ref int currentPosition, IWriter diagnosticsWriter)
        {
            var val = parameterModes[0] == 0 ? program[program[currentPosition + 1]] : program[currentPosition + 1];
   
            diagnosticsWriter.Write(val.ToString());
            
            currentPosition += 2;
            
            return program;
        }
    }
}