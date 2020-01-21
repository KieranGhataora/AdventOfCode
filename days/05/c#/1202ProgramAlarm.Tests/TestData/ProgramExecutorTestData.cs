using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1202ProgramAlarm.Tests.TestData
{
    public class ProgramExecutorTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> executorTestData = new List<object[]>()
        {
            new object[]
            {
                new[] {1002, 4, 3, 4, 33},
                new[] {1002, 4, 3, 4, 99}
            },
            new object[]
            {
                new[] {1001, 4, 3, 4, 96},
                new[] {1001, 4, 3, 4, 99}
            },
            new object[]
            {
                new[] {1, 0, 0, 0, 99},
                new[] {2, 0, 0, 0, 99}
            },
            new object[]
            {
                new[] {2, 3, 0, 3, 99},
                new[] {2, 3, 0, 6, 99}
            },
            new object[]
            {
                new[] {2, 4, 4, 5, 99, 0},
                new[] {2, 4, 4, 5, 99, 9801}
            },
            new object[]
            {
                new[] {1, 1, 1, 4, 99, 5, 6, 0, 99},
                new[] {30, 1, 1, 4, 2, 5, 6, 0, 99}
            },
            new object[]
            {
                new[] {1105, 5, 4, 4, 99},
                new[] {1105, 5, 4, 4, 99}                
            },
            new object[]
            {
                new[] {1005, 3, 4, 2, 99},
                new[] {1005, 3, 4, 2, 99}                
            },
            new object[]
            {
                new[] {5, 3, 5, 4, 2, 6, 99},
                new[] {5, 3, 5, 4, 2, 6, 99}                
            },
            new object[]
            {
                new[] {1106, 0, 4, 4, 99},
                new[] {1106, 0, 4, 4, 99}                
            },
            new object[]
            {
                new[] {1006, 3, 4, 0, 99},
                new[] {1006, 3, 4, 0, 99}                
            },
            new object[]
            {
                new[] {6, 3, 5, 0, 2, 6, 99},
                new[] {6, 3, 5, 0, 2, 6, 99}                
            }
        };

        public IEnumerator<object[]> GetEnumerator() => executorTestData.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}