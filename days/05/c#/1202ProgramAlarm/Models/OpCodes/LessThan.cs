using System.Linq;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class LessThan: OpCodeHandler
    {
        public LessThan() : base(7, false)
        {
        }

        public override int[] Execute(int[] program, int[] parameterModes, ref int currentPosition, IWriter diagnosticsWriter)
        {
            var copiedProgram = program.ToArray();
            
            var firstDigit =
                parameterModes[0] == 0 ? program[program[currentPosition + 1]] : program[currentPosition + 1];
            
            var secondDigit =
                parameterModes[1] == 0 ? program[program[currentPosition + 2]] : program[currentPosition + 2];

            var location = program[currentPosition + 3];

            copiedProgram[location] = firstDigit < secondDigit ? 1 : 0;

            currentPosition += 4;
            
            return copiedProgram;
        }
    }
}