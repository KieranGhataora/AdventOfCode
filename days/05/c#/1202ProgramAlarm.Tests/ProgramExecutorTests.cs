using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _1202ProgramAlarm.Models.Diagnostics;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace _1202ProgramAlarm.Tests
{
    public class ProgramExecutorTests
    {
        private readonly ProgramExecutor programExecutor;
        private readonly Mock<IWriter> mockWriter = new Mock<IWriter>();

        public ProgramExecutorTests(ITestOutputHelper output)
        {
            mockWriter.Setup(mw => mw.Write(It.IsAny<string>()));
            programExecutor = new ProgramExecutor(mockWriter.Object);
        }

        [Theory]
        [ClassData(typeof(ProgramExecutorTestData))]
        public void Test1(int[] program, int[] expectedOutput)
        {
            Assert.Equal(expectedOutput, programExecutor.ExecuteProgram(program));
        }

        [Fact]
        public void ExecuteProgram_OutputsCorrectDiagnostics()
        {
            programExecutor.ExecuteProgram(new[] {4, 30, 99});
            mockWriter.Verify(mw => mw.Write(It.Is<string>((t => t.Equals("30")))));
        }
    }
}

public class TestWriter : IWriter
{
    private readonly ITestOutputHelper output;

    public TestWriter(ITestOutputHelper output)
    {
        this.output = output;
    }

    public void Write(string text)
    {
        output.WriteLine(text);
    }
}

public class ProgramExecutorTestData : IEnumerable<object[]>
{
    private readonly List<object[]> executorTestData = new List<object[]>()
    {
        new object[]
        {
            new[] {1, 0, 0, 0, 99},
            new[]
            {
                2,
                0, 0, 0, 99
            }
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
            new[] {3, 4, 99, 0, 0},
            new[] {3, 4, 99, 0, 4},
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