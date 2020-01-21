using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using _1202ProgramAlarm.Models;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm
{
    public class ProgramExecutor
    {
        private readonly List<OpCodeHandler> opCodeHandlers = Assembly.GetAssembly(typeof(OpCodeHandler)).GetTypes()
            .Where(type => type.IsClass && !type.IsAbstract && type.IsSubclassOf(typeof(OpCodeHandler)))
            .Select(t => Activator.CreateInstance(t, null) as OpCodeHandler).ToList();

        private readonly IWriter writer;

        public ProgramExecutor(IWriter writer)
        {
            this.writer = writer;
        }

        public int[] ExecuteProgram(int[] program, int currentPosition = 0)
        {
            var instruction = program[currentPosition].ToString();

            int[] parameterModes;
            int opCode;
            
            if (instruction.Length == 1)
            {
                opCode = int.Parse(instruction);
                parameterModes = Enumerable.Repeat(0, 3).ToArray();
            }
            else
            {
                opCode = int.Parse(instruction.Substring(instruction.Length - 2));
                parameterModes = ParseParameterModes(instruction.Substring(0, instruction.Length - 2));
            }

            var opCodeHandler = opCodeHandlers.FirstOrDefault(och => och.Code.Equals(opCode));

            if (opCodeHandler == null) throw new NotImplementedException("Invalid OpCode!");

            return opCodeHandler.ExitCode
                ? program
                : ExecuteProgram(opCodeHandler.Execute(program, parameterModes, ref currentPosition, writer),
                    currentPosition);
        }

        private int[] ParseParameterModes(string modes)
        {
            var enumerable = modes
                .ToCharArray()
                .Select(char.GetNumericValue)
                .Select(Convert.ToInt32)
                .Reverse()
                .ToArray();

            return Enumerable.Repeat(0, 3)
                .Select((y, s) => s < enumerable.Length ? enumerable[s] : y).ToArray();
        }
    }
}