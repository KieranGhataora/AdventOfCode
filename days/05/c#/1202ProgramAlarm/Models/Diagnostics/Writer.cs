using System;

namespace _1202ProgramAlarm.Models.Diagnostics
{
    public class Writer: IWriter
    {
        public void Write(string text)
        {
            Console.WriteLine(text);
        }

        string IWriter.ReadLine() => Console.ReadLine();
        
        public string ReadLine => Console.ReadLine();
    }
}