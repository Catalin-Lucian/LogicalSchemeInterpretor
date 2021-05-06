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

        public String _Operator
        {
            get => _operator;
            set => _operator = value;
        }

        public double ExecuteOperation(IExpression firstTerm, IExpression secondTerm)
        {
            throw new NotImplementedException();
        }
    }
}
