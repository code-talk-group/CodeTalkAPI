using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Classes
{
    public class InputData
    {
        public string CreateSpokenCodeString(string baseString, List<string> formInputs)
        {
            string spokenCodeString = baseString;

            while (spokenCodeString.Contains("_")is true)
            {
                foreach (string input in formInputs)
                {
                    spokenCodeString.Replace("_", input);
                }
            }   
            return spokenCodeString;
        }
    }
}
