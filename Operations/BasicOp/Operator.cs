using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    if (secondTerm.Execute() != 0)
                        return firstTerm.Execute() / secondTerm.Execute();
                    else
                        return 0;
                default:
                    return 0;
            }
        }
    }
}
