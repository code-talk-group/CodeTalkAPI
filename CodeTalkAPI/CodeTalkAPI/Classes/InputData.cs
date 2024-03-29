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
        /// <summary>
        /// Creates a IOptionType with the JSON object recieved determines the IOption tyoe by the id given.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestObject"></param>
        /// <returns>Returns an IOptionType </returns>
        public static IOptionType CreateObjectFromOptionReceived(int id, JObject requestObject)
        {
            if(id == 1)
            {
                string[] functionParams = CreateFunctionParams(requestObject);
                FunctionInput functionInputs = new FunctionInput()
                {
                    MethodName = functionParams[0],
                    DataType = functionParams[1],
                    ParameterName = functionParams[2]
                };
                return functionInputs;
            }
            if (id == 2)
            {
                string[] forLoopParams = CreateForLoopParams(requestObject);
                ForLoopInput forLoopInputs = new ForLoopInput
                {
                    MethodName = forLoopParams[0],
                    ArrayName = forLoopParams[1],
                };
                return forLoopInputs;
            }
            if (id == 3)
            {
                string[] ifStatementParams = CreateIfStatementParams(requestObject);
                IfStatementInput ifStatementInputs = new IfStatementInput
                {
                    MethodName = ifStatementParams[0],
                    ParameterName = ifStatementParams[1],
                    IntegerValue = ifStatementParams[2],
                    IntegerValue2 = ifStatementParams[3],
                };
                return ifStatementInputs;
            }
            if (id == 4)
            {
                string[] variableParams = CreateVariableParams(requestObject);
                VariableInput variableInputs = new VariableInput
                {
                    MethodName = variableParams[0],
                    DataType = variableParams[1],
                    VariableName = variableParams[2],
                    VariableValue = variableParams[3]
                };
                return variableInputs;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// Takes in a JSON object an sets the parameters needed for the IOptionType of FunctionInput. 
        /// </summary>
        /// <param name="requestObject"></param>
        /// <returns>Returns an Array of strings</returns>
        public static string[] CreateFunctionParams(JObject requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string dataType = requestObject["DataType"].Value<string>();
            string parameterName = requestObject["ParameterName"].Value<string>();

            string[] functionParams = new string[3] { methodName, dataType, parameterName };
            return functionParams;
        }

        /// <summary>
        /// Takes in a JSON object an sets the parameters needed for the IOptionType of ForLoopInput. 
        /// </summary>
        /// <param name="requestObject"></param>
        /// <returns>Returns an Array of strings</returns>
        public static string[] CreateForLoopParams(JObject requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string arrayName = requestObject["ArrayName"].Value<string>();

            string[] forLoopParams = new string[2] { methodName, arrayName };
            return forLoopParams;
        }

        /// <summary>
        /// Takes in a JSON object an sets the parameters needed for the IOptionType of IfStatementInput.
        /// </summary>
        /// <param name="requestObject"></param>
        /// <returns>Returns an Array of strings</returns>
        public static string[] CreateIfStatementParams(JObject requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string parameterName = requestObject["ParameterName"].Value<string>();
            string integerValue = requestObject["IntegerValue"].Value<string>();

            string[] ifStatementParams = new string[4] { methodName, parameterName, integerValue, integerValue };
            return ifStatementParams;
        }

        /// <summary>
        /// Takes in a JSON object an sets the parameters needed for the IOptionType of VariableInput.
        /// </summary>
        /// <param name="requestObject"></param>
        /// <returns>Returns an Array of strings</returns>
        public static string[] CreateVariableParams(JObject requestObject)
        {
            string methodName = requestObject["MethodName"].Value<string>();
            string dataType = requestObject["DataType"].Value<string>();
            string variableName = requestObject["VariableName"].Value<string>();
            string variableValue = requestObject["VariableValue"].Value<string>();

            string[] variableParams = new string[4] { methodName, dataType, variableName, variableValue };
            return variableParams;
        }

        /// <summary>
        /// Creates a list and adds all the inputs for the base string from the JSON  object
        /// </summary>
        /// <param name="id"></param>
        /// <param name="requestObject"></param>
        /// <returns>Returns a List of strings </returns>
        public static List<string> CreateFormDataList(int id, JObject requestObject)
        {
            List<string> formDataList = new List<string>();

            if (id == 1)
            {
                string[] functionInputs = CreateFunctionParams(requestObject);
                foreach (string input in functionInputs)
                {
                    formDataList.Add(input);
                }
            }
            if(id == 2)
            {
                string[] forLoopInputs = CreateForLoopParams(requestObject);
                foreach (string input in forLoopInputs)
                {
                    formDataList.Add(input);
                }
            }
            if(id == 3)
            {
                string[] ifStatementInputs = CreateIfStatementParams(requestObject);
                foreach (string input in ifStatementInputs)
                {
                    formDataList.Add(input);
                }
            }
            if(id == 4)
            {
                string[] variableInputs = CreateVariableParams(requestObject);
                foreach (string input in variableInputs)
                {
                    formDataList.Add(input);
                }
            }

            return formDataList;
        }

        /// <summary>
        /// Replaces all the "_" in the basestring given with the values of the forminputs List.
        /// </summary>
        /// <param name="baseString"></param>
        /// <param name="formInputs"></param>
        /// <returns>Returns the modified version of baseString</returns>
        public static string CreateSpokenCodeString(string baseString, List<string> formInputs)
        {
            string spokenCodeString = baseString;

            foreach (string input in formInputs)
            {
               spokenCodeString = ReplaceFirstOccurence(spokenCodeString, "_", input);
            }
            
            return spokenCodeString;
        }

        /// <summary>
        /// Replaces every occurence of the toBeReplaced Characters inside the the original string with the replacement string  
        /// </summary>
        /// <param name="originalString"></param>
        /// <param name="toBeReplaced"></param>
        /// <param name="replacement"></param>
        /// <returns>Returns a new string</returns>
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
