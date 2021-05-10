using LogicalSchemeInterpretor.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor.CommandConfig
{
    public interface ICommandConfiguration
    {
        public void AddElement(ICommand command);
        public void RemoveElement(ICommand command);
        public void BindElementFirst(ICommand father, ICommand firstSon);
        public void BindElementSecond(ICommand father, ICommand secondSon);
        public Hashtable Graph
        {
            get; 
        }

        public List<ICommand> CommandList
        {
            get; 
        }

        public ICommand GetNextElement(ICommand key, bool isNextTrue);
    }
}
