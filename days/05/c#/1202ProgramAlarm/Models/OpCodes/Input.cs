using System;
using System.Linq;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class Input: OpCodeHandler
    {
        public Input() : base(3, false)
        {
        }

        public override int[] Execute(int[] program, int[] parameterModes,ref int currentPosition, IWriter diagnosticsWriter)
        {
            var copiedProgram = program.ToArray();

            var valToBeMoved = program[currentPosition + 1];
            
            Console.WriteLine("Please provide an input:");
            
            copiedProgram[valToBeMoved] = Convert.ToInt32(diagnosticsWriter.ReadLine());
            
            currentPosition += 2;
            
            return copiedProgram;
        }
    }
}