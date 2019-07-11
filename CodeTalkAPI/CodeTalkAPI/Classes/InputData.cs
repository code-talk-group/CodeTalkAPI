using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CodeTalkAPI.Classes
{
    public class InputData
    {
        public static object CreateObjectFromOptionReceived(int id, string requestObject)
        {
            if(id == 1)
            {
                string[] functionParams = CreateFunctionParams(requestObject);
                FunctionInput object = new FunctionInput
                {
                    MethodName = functionParams[0],
                    UserDataType = functionParams[1],
                    ParamName = functionParams[3]
                };
                return FunctionInput;
            }
            if (id == 2)
            {
                string[] forLoopParams = CreateFunctionParams(requestObject);
                ForLoopInput object = new ForLoopInput
                {
                    MethodName = forLoopParams[0],
                    ArrayName = forLoopParams[1],
                };
                return ForLoopInput;
            }
            if (id == 3)
            {
                string[] ifStatementParams = CreateFunctionParams(requestObject);
                IfStatementInput object = new IfStatementInput
                {
                    MethodName = ifStatementParams[0],
                    UserDataType = ifStatementParams[1],
                    ParamName = ifStatementParams[2],
                    PName2 = ifStatementParams[3]
                };
                return IfStatementInput;
            }
            if (id == 4)
            {
                string[] ifStatementParams = CreateFunctionParams(requestObject);
                VariableInput object = new BariableInput
                {
                    MethodName = ifStatementParams[0],
                    DataType = ifStatementParams[1],
                    VarName = ifStatementParams[2],
                    UserData = ifStatementParams[3]
                };
                return VariableInput;
            }
        }

        public static string[] CreateFunctionParams(string requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string userDataType = requestObject["UserDataType"].Value<string>();
            string paramName = requestObject["ParamName"].Value<string>();

            string[] functionParams = new string[3] { methodName, userDataType, paramName };
            return functionParams;
        }

        public static string[] CreateForLoopParams(string requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string arrayName = requestObject["ArrayName"].Value<string>();

            string[] forLoopParams = new string[2] { methodName, arrayName };
            return forLoopParams;
        }

        public static string[] CreateIfStatementParams(string requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string pName = requestObject["pName"].Value<string>();
            string userInt = requestObject["userInt"].Value<string>();
            string pName2 = requestObject["pName"].Value<string>();

            string[] ifStatementParams = new string[4] { methodName, pName, userInt, pName2 };
            return ifStatementParams;
        }

        public static string[] CreateVariableParams(string requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string dataType = requestObject["dataType"].Value<string>();
            string varName = requestObject["varName"].Value<string>();
            string userData = requestObject["userData"].Value<string>();

            string[] variableParams = new string[4] { methodName, dataType, varName, userData };
            return variableParams;
        }

        //public static List<string> CreateFormDataList(string formInputs)
        //{
        //    List<string> formDataList = new List<string>();
        //    string inputsData = formInputs;

        //    int count = inputsData.Count(c => c == ':');
        //    int counter = 0;

        //    while(counter <= count)
        //    {  
        //        string inputData = inputsData.Substring(inputsData.IndexOf(":"), inputsData.IndexOf("\""));
        //        formDataList.Add(inputData);
        //        inputsData.Remove(inputsData.IndexOf(":"), inputsData.IndexOf("\""));
        //        counter++;
        //    }

        //    return formDataList;
        //}

        public static string CreateSpokenCodeString(string baseString, List<string> formInputs)
        {
            string spokenCodeString = baseString;

            foreach (string input in formInputs)
            {
               spokenCodeString = ReplaceFirstOccurence(spokenCodeString, "_", input);
            }
            
            return spokenCodeString;
        }

        public static string ReplaceFirstOccurence(string originalString, string toBeReplaced, string replacement)
        {
            int occurence = originalString.IndexOf(toBeReplaced);
            if(occurence < 0)
            {
                return originalString;
            }

            return originalString.Substring(0, occurence) + replacement + originalString.Substring(occurence + toBeReplaced.Length);
        }
    }
}
