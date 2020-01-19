using System.Linq;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class Move: OpCodeHandler
    {
        public Move() : base(3, false)
        {
        }

        public override int[] Execute(int[] program, ref int currentPosition, IWriter diagnosticsWriter)
        {
            var copiedProgram = program.ToArray();

            var valToBeMoved = program[currentPosition + 1];
            
            copiedProgram[valToBeMoved] = valToBeMoved;
            
            currentPosition += 2;
            
            return copiedProgram;
        }
    }
}