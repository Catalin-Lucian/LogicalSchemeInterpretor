using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor
{
    class RelationalOperator:IRelationalOperator
    {
        private String _operator;
        public RelationalOperator(String opert)
        {
            _operator = opert;
        }

        public String _Operator
        {
            get => _operator;
            set => _operator = value;
        }

        public bool ExecuteCondition(IExpression firstExpression, IExpression secondExpression)
        {
            throw new NotImplementedException();
        }
    }
}
