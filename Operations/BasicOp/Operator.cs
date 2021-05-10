using System;

namespace LogicalSchemeInterpretor
{
    public class Operator : IOperator
    {
        private String _operator;
        public Operator(String oper)
        {
            _operator = oper;
        }

        public String Operator_
        {
            get => _operator;
            set => _operator = value;
        }

        public double ExecuteOperation(IExpression firstTerm, IExpression secondTerm)
        {
            switch (_operator)
            {
                case "+":
                    return firstTerm.Execute() + secondTerm.Execute();
                case "-":
                    return firstTerm.Execute() - secondTerm.Execute();
                case "*":
                    return firstTerm.Execute() * secondTerm.Execute();
                case "/":
                    return firstTerm.Execute() / secondTerm.Execute();
                default:
                    return 0;
            }
        }
    }
}
