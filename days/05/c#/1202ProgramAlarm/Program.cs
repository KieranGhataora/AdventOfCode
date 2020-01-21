using System;
using System.IO;
using System.Linq;
using System.Net;
using _1202ProgramAlarm.Models.Diagnostics;

namespace _1202ProgramAlarm
{
    static class Program
    {
        private static void Main(string[] args)
        {
            var programExecutor = new ProgramExecutor(new Writer());

            var fileInput = File.ReadAllText("input.txt")
                .Split(',')
                .Select(int.Parse)
                .ToArray();
            var fileInput2 = File.ReadAllText("input-2.txt")
                .Split(',')
                .Select(int.Parse)
                .ToArray();
            
            // var progOneResults = programExecutor.ExecuteProgram(fileInput)[0];
            var progTwoResults = programExecutor.ExecuteProgram(fileInput2)[0];
        }
    }
}
