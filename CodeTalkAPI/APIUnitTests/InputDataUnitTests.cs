using System;
using Xunit;
using System.Collections.Generic;
using CodeTalkAPI.Classes;
using System.Linq;
using Newtonsoft.Json.Linq;

namespace InputDataUnitTests
{
    public class UnitTest1
    {
        //[Fact]
        //public void CanCreateFormDataList()
        //{
        //    string testString = ["MethodName: Test", "DataType:int", "Parameter:testPara"];
        //    List<string> testFormInputs = new List<string> { "Test", "int", "testPara" };
        //    List<string> actualList = InputData.CreateFormDataList(testString);

        //    string actualResult = actualList.ElementAt(1);
        //    string expectedResult = testFormInputs.ElementAt(1);

        //    Assert.Equal(expectedResult, actualResult);
        //}

        [Fact]
        public void CanCreateFormDataListForIfStatement()
        {
            string stringOfObject = "{ \"ID\" : 4, \"CodeName\" : \"CName\", \"MethodName\" : \"NameOfMethod\", \"ParameterName\" : \"NameOfParameter\", \"IntegerValue\": \"ValueOfInteger\"}";
            JObject testObject = JObject.Parse(stringOfObject);

            List<string> expectedStringList = new List<string>(new string[] { "NameOfMethod", "NameOfParameter", "ValueOfInteger", "ValueOfInteger" });
            List<string> actualStringList = InputData.CreateFormDataList(3, testObject);

            Assert.Equal(expectedStringList, actualStringList);
        }

        [Fact]
        public void CanCreateFormDataListForForLoop()
        {
            string stringOfObject = "{ \"ID\" : 4, \"CodeName\" : \"CName\", \"MethodName\" : \"NameOfMethod\",\"ArrayName\": \"NameOfArray\"}";
            JObject testObject = JObject.Parse(stringOfObject);

            List<string> expectedStringList = new List<string>(new string[] { "NameOfMethod", "NameOfArray" });
            List<string> actualStringList = InputData.CreateFormDataList(2, testObject);

            Assert.Equal(expectedStringList, actualStringList);
        }

        [Fact]
        public void CanCreateFormDataListForFunction()
        {
            string stringOfObject = "{ \"ID\" : 4, \"CodeName\" : \"CName\", \"MethodName\" : \"NameOfMethod\", \"DataType\" : \"TestType\", \"ParameterName\": \"NameOfParameter\"}";
            JObject testObject = JObject.Parse(stringOfObject);

            List<string> expectedStringList = new List<string>(new string[] { "NameOfMethod", "TestType", "NameOfParameter" });
            List<string> actualStringList = InputData.CreateFormDataList(1, testObject);

            Assert.Equal(expectedStringList, actualStringList);
        }

        [Fact]
        public void CanCreateVariableParamsStringArray()
        {
            string stringOfObject = "{ \"ID\" : 4, \"CodeName\" : \"CName\", \"MethodName\" : \"NameOfMethod\", \"DataType\" : \"TypeOfData\", \"VariableName\": \"NameOfVariable\", \"VariableValue\": \"ValueOfVariable\"}";
            JObject testObject = JObject.Parse(stringOfObject);

            string[] expectedStringArray = new string[4] { "NameOfMethod", "TypeOfData", "NameOfVariable", "ValueOfVariable" };
            string[] actualStringArray = InputData.CreateVariableParams(testObject);

            Assert.Equal(expectedStringArray, actualStringArray);
        }

        [Fact]
        public void CanCreateIfStatementParamsStringArray()
        {
            string stringOfObject = "{ \"ID\" : 4, \"CodeName\" : \"CName\", \"MethodName\" : \"NameOfMethod\", \"ParameterName\" : \"NameOfParameter\", \"IntegerValue\": \"ValueOfInteger\"}";
            JObject testObject = JObject.Parse(stringOfObject);

            string[] expectedStringArray = new string[4] { "NameOfMethod", "NameOfParameter", "ValueOfInteger", "ValueOfInteger" };
            string[] actualStringArray = InputData.CreateIfStatementParams(testObject);

            Assert.Equal(expectedStringArray, actualStringArray);
        }

        [Fact]
        public void CanCreateForLoopParamsStringArray()
        {
            string stringOfObject = "{ \"ID\" : 4, \"CodeName\" : \"CName\", \"MethodName\" : \"NameOfMethod\",\"ArrayName\": \"NameOfArray\"}";
            JObject testObject = JObject.Parse(stringOfObject);

            string[] expectedStringArray = new string[2] { "NameOfMethod", "NameOfArray" };
            string[] actualStringArray = InputData.CreateForLoopParams(testObject);

            Assert.Equal(expectedStringArray, actualStringArray);
        }

        [Fact]
        public void CanCreateFunctionParamsStringArray()
        {
            string stringOfObject = "{ \"ID\" : 4, \"CodeName\" : \"CName\", \"MethodName\" : \"NameOfMethod\", \"DataType\" : \"TestType\", \"ParameterName\": \"NameOfParameter\"}";
            JObject testObject = JObject.Parse(stringOfObject);

            string[] expectedStringArray = new string[3] { "NameOfMethod", "TestType", "NameOfParameter" };
            string[] actualStringArray = InputData.CreateFunctionParams(testObject);

            Assert.Equal(expectedStringArray, actualStringArray);
        }

        [Fact]
        public void CanCreateSpokenCodeStringForVariable()
        {
            string testBaseString = "_ is a public method with a void return type. A _ variable called _ is declared and set to equal _.";
            List<string> testFormInputs = new List<string> { "MethodName", "DataType", "VariableName", "VariableValue" };
            string actualResult = InputData.CreateSpokenCodeString(testBaseString, testFormInputs);
            string expectedResult = "MethodName is a public method with a void return type. A DataType variable called VariableName is declared and set to equal VariableValue.";

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void CanCreateSpokenCodeStringForIfStatement()
        {
            string testBaseString = "_ is a public method with a void return type that takes in an integer named _. The integer's value is then set to _. Our if statement determines if _ is less than 10. If this is true, Yes is printed to the console. If this is not true, our else statement will print No to the console.";
            List<string> testFormInputs = new List<string> { "MethodName", "Parameter", "IntegerValue", "IntegerValue2" };
            string actualResult = InputData.CreateSpokenCodeString(testBaseString, testFormInputs);
            string expectedResult = "MethodName is a public method with a void return type that takes in an integer named Parameter. The integer's value is then set to IntegerValue. Our if statement determines if IntegerValue2 is less than 10. If this is true, Yes is printed to the console. If this is not true, our else statement will print No to the console.";

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void CanCreateSpokenCodeStringForForLoop()
        {
            string testBaseString = "_ is a public method which takes in an integer array called _ and returns an integer. A counter is declared and set to zero. A For Loop iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is completed the counter is returned.";
            List<string> testFormInputs = new List<string> { "MethodName", "ArrayName" };
            string actualResult = InputData.CreateSpokenCodeString(testBaseString, testFormInputs);
            string expectedResult = "MethodName is a public method which takes in an integer array called ArrayName and returns an integer. A counter is declared and set to zero. A For Loop iterates through the array as long as i is less than the length of the array and adds 1 to the counter. When the loop is completed the counter is returned.";

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void CanCreateSpokenCodeStringForFunction()
        {
            string testBaseString = "_ is a public method with a void return type that takes in a  _ called _. When the method is called all the statements and arguments defined within the curly braces will run.";
            List<string> testFormInputs = new List<string> { "MethodName", "DataType", "Parameter" };
            string actualResult = InputData.CreateSpokenCodeString(testBaseString, testFormInputs);
            string expectedResult = "MethodName is a public method with a void return type that takes in a  DataType called Parameter. When the method is called all the statements and arguments defined within the curly braces will run.";

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void CanReplaceFirstOccurence()
        {
            string testString = "Hello _, welcome to this test";
            string testToBeReplace = "_";
            string testReplacement = "name";
            string expectedResult = "Hello name, welcome to this test";

            string actualResult = InputData.ReplaceFirstOccurence(testString, testToBeReplace, testReplacement);

            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void ReplacesOnlyFirstOccurenceAndNoneOfTheOccurencesAfter()
        {
            string testString = "Hello _, _ to this _";
            string testToBeReplace = "_";
            string testReplacement = "name";
            string expectedResult = "Hello name, _ to this _";

            string actualResult = InputData.ReplaceFirstOccurence(testString, testToBeReplace, testReplacement);

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
