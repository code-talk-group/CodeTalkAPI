using System;
using Xunit;
using System.Collections.Generic;
using CodeTalkAPI.Classes;
using System.Linq;


namespace ClassMethodUnitTests
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
