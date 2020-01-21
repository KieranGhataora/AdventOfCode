using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class JumpIfTrue: OpCodeHandler
    {
        public JumpIfTrue() : base(5, false)
        {
        }

        public override int[] Execute(int[] program, int[] parameterModes, ref int currentPosition, IWriter diagnosticsWriter)
        {
            var input =
                parameterModes[0] == 0 ? program[program[currentPosition + 1]] : program[currentPosition + 1];

            if (input != 0)
            {
                currentPosition = parameterModes[1] == 0 ? program[program[currentPosition + 2]] : program[currentPosition + 2];
            }
            else
            {
                currentPosition += 3;
            }

            return program;
        }
    }
}