using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Classes
{
    public class UserInput
    {
        public class FuntionInput
        {
            public string MethodName { get; set; }

            public string UserDataType { get; set; }

            public string ParamName { get; set; }

            /// <summary>
            /// Creates a Function Input  
            /// </summary>
            /// <param name="methodName"></param>
            /// <param name="userDataType"></param>
            /// <param name="paramName"></param>
            public FuntionInput(string methodName, string userDataType, string paramName)
            {
                MethodName = methodName;
                UserDataType = userDataType;
                ParamName = paramName;
            }
        }

        public class ForLoopInput
        {
            public string MethodName { get; set; }

            public string ArrayName { get; set; }

            /// <summary>
            /// Creates a For Loop Input object 
            /// </summary>
            /// <param name="methodName"></param>
            /// <param name="arrayName"></param>
            public ForLoopInput(string methodName, string arrayName)
            {
                MethodName = methodName;
                ArrayName = arrayName;
            }
        }

        public class IfStatmentInput
        {
            public string MethodName { get; set; }

            public string PName { get; set; }

            public string PName2 { get; set; }

            public string UserInt { get; set; }

            /// <summary>
            /// Creates a If Statment Input object
            /// </summary>
            /// <param name="methodName"></param>
            /// <param name="pName"></param>
            /// <param name="userInt"></param>
            /// <param name="pName2"></param>
            public IfStatmentInput(string methodName, string pName, string userInt, string pName2)
            {
                MethodName = methodName;
                PName = pName;
                UserInt = userInt;
                PName2 = pName2;
            }
        }
        
        public class VariableInput
        {
            public string MethodName { get; set; }

            public string DataType { get; set; }

            public string VarName { get; set; }

            public string UserData { get; set; }

            /// <summary>
            /// Creates a Variable Input object 
            /// </summary>
            /// <param name="dataType"></param>
            /// <param name="methodName"></param>
            /// <param name="varName"></param>
            /// <param name="userData"></param>
            public VariableInput(string methodName, string dataType, string varName, string userData)
            {
                MethodName = methodName;
                DataType = dataType;
                VarName = varName;
                UserData = userData;
            }
        }
    }
}
