using System.Linq;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class Multiply : OpCodeHandler
    {
        public Multiply() : base(2, false)
        {
        }

        public override int[] Execute(int[] program, int currentPosition)
        {
            var copiedProgram = program.ToArray();

            copiedProgram[program[currentPosition + 3]] =
                copiedProgram[program[currentPosition + 1]] * copiedProgram[program[currentPosition + 2]];

            return copiedProgram;
        }
    }
}