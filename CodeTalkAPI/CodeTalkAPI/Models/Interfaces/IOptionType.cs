using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTalkAPI.Classes
{
    public interface IOptionType
    {
        int Id { get; set; }
        string CodeName { get; set; }
        string MethodName { get; set; }
    }

    public class FunctionInput : IOptionType
    {
        public string DataType { get; set; }
        public string ParameterName { get; set; }
        public int Id { get; set; }
        public string CodeName { get; set; }
        public string MethodName { get; set; }
    }

    public class ForLoopInput : IOptionType
    {
        public string ArrayName { get; set; }
        public int Id { get; set; }
        public string CodeName { get; set; }
        public string MethodName { get; set; }
    }

    public class IfStatementInput : IOptionType
    {
        public string ParameterName { get; set; }
        public string IntegerValue { get; set; }
        public string IntegerValue2 { get; set; }
        public int Id { get; set; }
        public string CodeName { get; set; }
        public string MethodName { get; set; }
    }

    public class VariableInput : IOptionType
    {
        public string DataType { get; set; }
        public string VariableName { get; set; }
        public string VariableValue { get; set; }
        public int Id { get; set; }
        public string CodeName { get; set; }
        public string MethodName { get; set; }
    }
}
