using System;
using System.Linq;
using _1202ProgramAlarm.Models;

namespace _1202ProgramAlarm
{
    public class ProgramExecutor
    {
        public int[] ExecuteProgram(int[] program, int currentPosition = 0)
        {
            var opCode = (OpCode) program[currentPosition];
            var copiedProgram = program.ToArray();

            switch (opCode)
            {
                case OpCode.Add:
                    copiedProgram[program[currentPosition + 3]] =
                        copiedProgram[program[currentPosition + 1]] + copiedProgram[program[currentPosition + 2]];
                    break;
                case OpCode.Multiply:
                    copiedProgram[program[currentPosition + 3]] =
                        copiedProgram[program[currentPosition + 1]] * copiedProgram[program[currentPosition + 2]];
                    break;
                case OpCode.Exit:
                    return copiedProgram;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            
            return ExecuteProgram(copiedProgram, currentPosition + 4);
        }
    }
}