using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using _1202ProgramAlarm.Models.Diagnostics;
using _1202ProgramAlarm.Tests.TestData;
using Microsoft.VisualStudio.TestPlatform.TestHost;
using Moq;
using Xunit;
using Xunit.Abstractions;
using Xunit.Sdk;

namespace _1202ProgramAlarm.Tests
{
    public class ProgramExecutorTests
    {
        private ProgramExecutor programExecutor;
        private readonly Mock<IWriter> mockWriter = new Mock<IWriter>();

        public ProgramExecutorTests(ITestOutputHelper output)
        {
            mockWriter.Setup(mw => mw.Write(It.IsAny<string>())).Callback<string>(output.WriteLine);
        }

        [Theory]
        [ClassData(typeof(ProgramExecutorTestData))]
        public void ExecuteProgram_CorrectlyParsesProgram(int[] program, int[] expectedOutput)
        {
            programExecutor = new ProgramExecutor(mockWriter.Object);
            Assert.Equal(expectedOutput, programExecutor.ExecuteProgram(program));
        }

        [Theory]
        [ClassData(typeof(OutputsCorrectDiagnosticsTestData))]
        public void ExecuteProgram_OutputsCorrectDiagnostics(int[] program, string expectedOutput)
        {
            programExecutor = new ProgramExecutor(mockWriter.Object);
            programExecutor.ExecuteProgram(program);
            mockWriter.Verify(mw => mw.Write(It.Is<string>((t => t.Equals(expectedOutput)))));
        }
        
        [Theory]
        [ClassData(typeof(ReadsInCorrectlyTestData))]
        public void ExecuteProgram_ReadsInCorrectly(int[] program, int positionValue, int inputValue)
        {
            mockWriter.Setup(mw => mw.ReadLine()).Returns("2");
            programExecutor = new ProgramExecutor(mockWriter.Object);
            var output = programExecutor.ExecuteProgram(program);
            Assert.Equal(inputValue, output[positionValue]);
        }

        [Theory]
        [ClassData(typeof(LessThanTestData))]
        public void ExecuteProgram_LessThanOpCodeWorksAsExpected(int[] program, int[] expectedOutput)
        {
            programExecutor = new ProgramExecutor(mockWriter.Object);
            Assert.Equal(expectedOutput, programExecutor.ExecuteProgram(program));
        }
        
        [Theory]
        [ClassData(typeof(EqualsTestData))]
        public void ExecuteProgram_EqualsOpCodeWorksAsExpected(int[] program, int[] expectedOutput)
        {
            programExecutor = new ProgramExecutor(mockWriter.Object);
            Assert.Equal(expectedOutput, programExecutor.ExecuteProgram(program));
        }

        [Theory]
        [ClassData(typeof(ExecutionOutputsCorrectDiagnosticsCodeTestData))]
        public void ExecuteProgram_OutputsCorrectDiagnosticsCode(int[] program, string readLineOutput,
            string expectedOutput)
        {
            mockWriter.Setup(mw => mw.ReadLine()).Returns(readLineOutput);
            programExecutor = new ProgramExecutor(mockWriter.Object);
            var output = programExecutor.ExecuteProgram(program);
            mockWriter.Verify(mw => mw.Write(It.Is<string>(s => s.Equals(expectedOutput))));
       
        }
    }
}

