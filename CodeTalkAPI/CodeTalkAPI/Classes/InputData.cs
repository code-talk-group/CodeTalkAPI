using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Classes
{
    public class InputData
    {
        public static List<string> CreateFormDataList(string formInputs)
        {
            List<string> formDataList = new List<string>();
            string inputsData = formInputs;

            int inputsCount = formInputs.TakeWhile(c => c == ':').Count();

            while (inputsData.Contains(":") is true)
            {
                string inputData = inputsData.Substring(inputsData.IndexOf(":"), inputsData.IndexOf("\""));
                formDataList.Add(inputData);
                inputsData.Remove(inputsData.IndexOf(":"), inputsData.IndexOf("\""));
            }

            return formDataList;
        }


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
