using System.Linq;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class Exit: OpCodeHandler
    {
        public Exit() : base(99, true)
        {
        }

        public override int[] Execute(int[] program, int currentPosition)
        {
            return program;
        }
    }
}