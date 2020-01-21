using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1202ProgramAlarm.Tests.TestData
{
    public class LessThanTestData : IEnumerable<object[]>
    {
        private readonly List<object[]> executorTestData = new List<object[]>()
        {
            new object[]
            {
                new[] {1107, 1, 2, 3, 99},
                new[] {1107, 1, 2, 1, 99}
            },
            new object[]
            {
                new[] {1107, 2, 1, 3, 99},
                new[] {1107, 2, 1, 0, 99}
            },
            new object[]
            {
                new[] {1007, 3, 4, 3, 99},
                new[] {1007, 3, 4, 1, 99}
            },
            new object[]
            {
                new[] {1007, 4, 4, 3, 99},
                new[] {1007, 4, 4, 0, 99}
            },
            new object[]
            {
                new[] {7, 3, 4, 3, 99},
                new[] {7, 3, 4, 1, 99}
            },
            new object[]
            {
                new[] {7, 4, 3, 3, 99},
                new[] {7, 4, 3, 0, 99}
            }
        };

        public IEnumerator<object[]> GetEnumerator() => executorTestData.AsEnumerable().GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}