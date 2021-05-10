using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor.CommandTypes
{
    class Decision : ICommandType
    {
        private ICondition _condition;
        private Boolean _nextElement;

        public Decision(ICondition conditie)
        {
            _condition = conditie;
        }

        public ICondition Conditie
        {
            get { return _condition; }
            set { _condition = value; }
        }

        public void Execute()
        {
            _nextElement = _condition.ExecuteCondition();
        }

        public bool GetNext()
        {
            return _nextElement;
        }
    }
}
