﻿namespace LogicalSchemeInterpretor
{
    class NegCondition : ICondition
    {
        private ICondition _condition;

        public NegCondition(ICondition condition)
        {
            _condition = condition;
        }

        public ICondition Condition
        {
            get => _condition;
            set => _condition = value;
        }

        public bool ExecuteCondition()
        {
            return !Condition.ExecuteCondition();
        }
    }
}
