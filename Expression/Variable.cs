using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor
{
    public class Variable : IExpression
    {
        private double _value;
        private readonly String _name;

        public  Variable(String name)
        {
            _name = name;
        }

        public double Value
        {
            get => _value;
            set => _value = value;
        }

        public String Name
        {
            get => _name;
        }

        public double Execute()
        {
            return _value;
        }
    }
}
