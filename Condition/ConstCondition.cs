﻿namespace LogicalSchemeInterpretor
{
    class ConstCondition : ICondition
    {
        private bool _value;

        public ConstCondition(bool value)
        {
            _value = value;
        }

        public bool Value
        {
            get => _value;
            set => _value = value;
        }
        public bool ExecuteCondition()
        {
            return Value;
        }
    }
}