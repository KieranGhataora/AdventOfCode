﻿using System.Linq;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm.Models.OpCodes
{
    public class Multiply : OpCodeHandler
    {
        public Multiply() : base(2, false)
        {
        }

        public override int[] Execute(int[] program, ref int currentPosition, IWriter diagnosticsWriter)
        {
            var copiedProgram = program.ToArray();

            copiedProgram[program[currentPosition + 3]] =
                copiedProgram[program[currentPosition + 1]] * copiedProgram[program[currentPosition + 2]];

            currentPosition += 4;
            
            return copiedProgram;
        }
    }
}