using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Xunit;

namespace _1202ProgramAlarm.Tests
{
    public class ProgramExecutorTests
    {
        private ProgramExecutor programExecutor = new ProgramExecutor();
        
        [Theory]
        [ClassData(typeof(ProgramExecutorTestData))]
        public void Test1(int[] program, int[] expectedOutput)
        {
            Assert.Equal(expectedOutput, programExecutor.ExecuteProgram(program));
        }
    }
}

public class ProgramExecutorTestData : IEnumerable<object[]>
{
    private readonly List<object[]> executorTestData = new List<object[]>()
    {
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
        }
    };

    public IEnumerator<object[]> GetEnumerator() => executorTestData.AsEnumerable().GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}

public class TestDataUnit
{
    public int[] Program { get; set; }
    public int[] ExpectedOutput { get; set; }
}