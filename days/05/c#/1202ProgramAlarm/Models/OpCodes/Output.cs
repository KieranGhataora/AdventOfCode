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

        public override int[] Execute(int[] program, ref int currentPosition, IWriter diagnosticsWriter)
        {
            diagnosticsWriter.Write(program[currentPosition + 1].ToString());
            
            currentPosition += 2;
            
            return program;
        }
    }
}