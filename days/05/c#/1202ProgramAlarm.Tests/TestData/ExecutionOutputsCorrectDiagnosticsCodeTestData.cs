using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1202ProgramAlarm.Tests.TestData
{
    public class ExecutionOutputsCorrectDiagnosticsCodeTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> executorTestData = new List<object[]>()
        {
            new object[] {new[] {3,9,8,9,10,9,4,9,99,-1,8}, "7", "0"},
            new object[] {new[] {3,9,8,9,10,9,4,9,99,-1,8}, "8", "1"},
            new object[] {new[] {3,9,7,9,10,9,4,9,99,-1,8}, "7", "1"},
            new object[] {new[] {3,9,7,9,10,9,4,9,99,-1,8}, "8", "0"}
        };
    
        public IEnumerator<object[]> GetEnumerator() => executorTestData.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}