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

        private IWriter writer;

        public ProgramExecutor(IWriter writer)
        {
            this.writer = writer;
        }

        public int[] ExecuteProgram(int[] program, int currentPosition = 0)
        {
            var opCodeHandler = opCodeHandlers.FirstOrDefault(och => och.Code.Equals(program[currentPosition]));
            
            if (opCodeHandler == null) throw new NotImplementedException("Invalid OpCode!");
            
            return opCodeHandler.ExitCode
                ? program
                : ExecuteProgram(opCodeHandler.Execute(program, ref currentPosition, writer), currentPosition);
        }
    }
}