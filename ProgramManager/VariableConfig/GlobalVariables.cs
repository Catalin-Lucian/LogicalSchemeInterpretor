using LogicalSchemeInterpretor.Commands;
using System.Collections.Generic;

namespace LogicalSchemeInterpretor.VarConfig
{
    class GlobalVariables : IVariableConfiguration
    {
        private List<Variable> _listOfVariables;
        public List<Variable> VariableList {
            get{
                return _listOfVariables;
            }
        }

        public void AddElement(Variable variable)
        {
            _listOfVariables.Add(variable);
        }

        public Variable GetVariableByName(string name)
        {
            foreach(Variable variable in _listOfVariables)
            {
                if (variable.Name == name)
                    return variable;
            }
            return null;
        }

        public void RemoveElement(Variable variable)
        {
            _listOfVariables.Remove(variable);
        }

    }
}
