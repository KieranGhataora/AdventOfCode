using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1202ProgramAlarm.Tests.TestData
{
    public class EqualsTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> executorTestData = new List<object[]>()
        {
            new object[]
            {
                new[] {1108, 2, 2, 3, 99},
                new[] {1108, 2, 2, 1, 99}
            },
            new object[]
            {
                new[] {1108, 2, 1, 3, 99},
                new[] {1108, 2, 1, 0, 99}
            },
            new object[]
            {
                new[] {1008, 3, 4, 3, 99},
                new[] {1008, 3, 4, 0, 99}
            },
            new object[]
            {
                new[] {1008, 4, 4, 3, 99},
                new[] {1008, 4, 4, 0, 99}
            },
            new object[]
            {
                new[] {8, 3, 3, 3, 99},
                new[] {8, 3, 3, 1, 99}
            },
            new object[]
            {
                new[] {8, 4, 3, 3, 99},
                new[] {8, 4, 3, 0, 99}
            }
        };

        public IEnumerator<object[]> GetEnumerator() => executorTestData.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}