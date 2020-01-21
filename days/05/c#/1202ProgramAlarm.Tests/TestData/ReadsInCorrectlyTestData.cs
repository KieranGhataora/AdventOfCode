using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1202ProgramAlarm.Tests.TestData
{
    public class ReadsInCorrectlyTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> executorTestData = new List<object[]>()
        {
            new object[] {new[] {3, 1, 99}, 1, 2}
        };
    
        public IEnumerator<object[]> GetEnumerator() => executorTestData.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}