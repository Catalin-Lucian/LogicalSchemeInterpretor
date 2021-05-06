﻿namespace LogicalSchemeInterpretor
{
    public class ConstValue : IExpression
    {
        private double _value;
        public ConstValue(double value)
        {
            _value = value;
        }


        public double Value
        {
            get => _value;
            set => _value = value;
        }

        public double Execute()
        {
            return _value;
        }
    }
}