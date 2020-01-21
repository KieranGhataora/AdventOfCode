using System.Linq;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class Exit: OpCodeHandler
    {
        public Exit() : base(99, true)
        {
        }

        public override int[] Execute(int[] program, int[] parameterModes, ref int currentPosition, IWriter diagnosticsWriter)
        {
            return program;
        }
    }
}