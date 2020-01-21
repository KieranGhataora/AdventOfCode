using System.Linq;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class Add : OpCodeHandler
    {
        public Add() : base(1, false)
        {
        }

        public override int[] Execute(int[] program, int[] parameterModes, ref int currentPosition, IWriter diagnosticsWriter)
        {
            var copiedProgram = program.ToArray();

            var parameters = GetParameters(program, parameterModes, currentPosition, 3);

            copiedProgram[parameters[2]] = parameters[0] + parameters[1];

            currentPosition += 4;
            
            return copiedProgram;
        }
    }
}