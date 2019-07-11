﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static CodeTalkAPI.Classes.UserInput;

namespace CodeTalkAPI.Classes
{
    public class InputData
    {
        public static object CreateObjectFromOptionReceived(int id, JObject requestObject)
        {
            if(id == 1)
            {
                string[] functionParams = CreateFunctionParams(requestObject);
                FunctionInput functionInputs = new FunctionInput()
                {
                    MethodName = functionParams[0],
                    UserDataType = functionParams[1],
                    ParamName = functionParams[3]
                };
                return functionInputs;
            }
            if (id == 2)
            {
                string[] forLoopParams = CreateFunctionParams(requestObject);
                ForLoopInput forLoopInputs = new ForLoopInput
                {
                    MethodName = forLoopParams[0],
                    ArrayName = forLoopParams[1],
                };
                return forLoopInputs;
            }
            if (id == 3)
            {
                string[] ifStatementParams = CreateFunctionParams(requestObject);
                IfStatementInput ifStatementInputs = new IfStatementInput
                {
                    MethodName = ifStatementParams[0],
                    PName = ifStatementParams[1],
                    UserInt = ifStatementParams[2],
                    PName2 = ifStatementParams[3]
                };
                return ifStatementInputs;
            }
            if (id == 4)
            {
                string[] ifStatementParams = CreateFunctionParams(requestObject);
                VariableInput variableInputs = new VariableInput
                {
                    MethodName = ifStatementParams[0],
                    DataType = ifStatementParams[1],
                    VarName = ifStatementParams[2],
                    UserData = ifStatementParams[3]
                };
                return variableInputs;
            }
            else
            {
                return null;
            }
        }

        public static string[] CreateFunctionParams(JObject requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string userDataType = requestObject["UserDataType"].Value<string>();
            string paramName = requestObject["ParamName"].Value<string>();

            string[] functionParams = new string[3] { methodName, userDataType, paramName };
            return functionParams;
        }

        public static string[] CreateForLoopParams(JObject requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string arrayName = requestObject["ArrayName"].Value<string>();

            string[] forLoopParams = new string[2] { methodName, arrayName };
            return forLoopParams;
        }

        public static string[] CreateIfStatementParams(JObject requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string pName = requestObject["pName"].Value<string>();
            string userInt = requestObject["userInt"].Value<string>();
            string pName2 = requestObject["pName"].Value<string>();

            string[] ifStatementParams = new string[4] { methodName, pName, userInt, pName2 };
            return ifStatementParams;
        }

        public static string[] CreateVariableParams(JObject requestObject)
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
