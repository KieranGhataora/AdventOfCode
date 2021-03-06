﻿using System;
using System.IO;
using System.Linq;
using System.Net;

namespace _1202ProgramAlarm
{
    class Program
    {
        static void Main(string[] args)
        {
            var programExecutor = new ProgramExecutor();

            var fileInput = File.ReadAllText("../../input.txt")
                .Split(',')
                .Select(int.Parse)
                .ToArray();
            
            Console.WriteLine(programExecutor.ExecuteProgram(fileInput)[0]);

            for (var i = 0; i < 100; i++)
            {
                for (var j = 0; j < 100; j++)
                {
                    fileInput[1] = i;
                    fileInput[2] = j;

                    if (programExecutor.ExecuteProgram(fileInput)[0] != 19690720) continue;
                    
                    Console.WriteLine($"Noun: {i}, Verb: {j}");
                    Console.WriteLine(100*i + j);
                    break;
                }
            }
            
        }
    }
}
