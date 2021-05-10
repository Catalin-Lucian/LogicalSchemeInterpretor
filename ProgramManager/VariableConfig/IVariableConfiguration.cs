using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor.VarConfig
{
    public interface IVariableConfiguration
    {
        public void AddElement(Variable variable);
        public void RemoveElement(Variable variable);
        public Variable GetVariableByName(string name);
        List<Variable> VariableList
        {
            get;
        }

    }
}
