namespace _1202ProgramAlarm.Models.Diagnostics
{
    public interface IWriter
    {
        public void Write(string text);
        public string ReadLine();
    }
}