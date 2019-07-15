using System;
using Xunit;
using System.Collections.Generic;
using System.Text;
using CodeTalkAPI.Models;
using CodeTalkAPI.Classes;

namespace UserInputUnitTests
{
    public class UnitTests
    {
        [Fact]
        public void CanGetValuesOfEveryFunctionInputProperty()
        {
            FunctionInput functionInput = new FunctionInput()
            {
                Id = 1,
                CodeName = "TestFunction",
                MethodName = "TestMethod",
                DataType = "TestBool",
                ParameterName = "TestParam"
            };

            Assert.Equal("1", functionInput.Id.ToString());
            Assert.Equal("TestFunction", functionInput.CodeName);
            Assert.Equal("TestMethod", functionInput.MethodName);
            Assert.Equal("TestBool", functionInput.DataType);
            Assert.Equal("TestParam", functionInput.ParameterName);
        }

        [Fact]
        public void CanGetValuesOfEveryForLoopInputProperty()
        {
            ForLoopInput forLoopInput = new ForLoopInput()
            {
                Id = 2,
                CodeName = "TestForLoop",
                MethodName = "TestMethod",
                ArrayName = "TestArray"
            };

            Assert.Equal("2", forLoopInput.Id.ToString());
            Assert.Equal("TestForLoop", forLoopInput.CodeName);
            Assert.Equal("TestMethod", forLoopInput.MethodName);
            Assert.Equal("TestArray", forLoopInput.ArrayName);
        }

        [Fact]
        public void CanGetValuesOfEveryIfStatementInputProperty()
        {
            IfStatementInput ifStatementInput = new IfStatementInput()
            {
                Id = 3,
                CodeName = "TestIfStatement",
                MethodName = "TestMethod",
                ParameterName = "TestParam",
                IntegerValue = "TestValue",
                IntegerValue2 = "TestValue"
            };

            Assert.Equal("3", ifStatementInput.Id.ToString());
            Assert.Equal("TestIfStatement", ifStatementInput.CodeName);
            Assert.Equal("TestMethod", ifStatementInput.MethodName);
            Assert.Equal("TestParam", ifStatementInput.ParameterName);
            Assert.Equal("TestValue", ifStatementInput.IntegerValue);
            Assert.Equal("TestValue", ifStatementInput.IntegerValue2);
        }

        [Fact]
        public void CanGetValuesOfEveryVariableInputProperty()
        {
            VariableInput variableInput = new VariableInput()
            {
                Id = 4,
                CodeName = "TestVariable",
                MethodName = "TestMethod",
                DataType = "TestInt",
                VariableName = "TestVarName",
                VariableValue = "TestValue"
            };

            Assert.Equal("4", variableInput.Id.ToString());
            Assert.Equal("TestVariable", variableInput.CodeName);
            Assert.Equal("TestMethod", variableInput.MethodName);
            Assert.Equal("TestInt", variableInput.DataType);
            Assert.Equal("TestVarName", variableInput.VariableName);
            Assert.Equal("TestValue", variableInput.VariableValue);
        }
    }
}
