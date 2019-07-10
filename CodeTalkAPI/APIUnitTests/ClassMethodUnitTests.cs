using System;
using Xunit;
using System.Collections.Generic;
using CodeTalkAPI.Classes;


namespace ClassMethodUnitTests
{
    public class UnitTest1
    {
        [Fact]
        public void CanCreateSpokenCodeString()
        {
            string testBaseString = "_ is a public method with a void return type that takes in a _ called _. When the method is called all the statements and arguments defined within the curly braces will run.";
            List<string> testFormInputs = new List<string> { "MethodName", "DataType", "Parameter" };
            string actualResult = InputData.CreateSpokenCodeString(testBaseString, testFormInputs);
            string expectedResult = "MethodName is a public method with a void return type that takes in a DataType called Parameter. When the method is called all the statements and arguments defined within the curly braces will run.";

            Assert.Equal(expectedResult, actualResult);
        }
    }
}
