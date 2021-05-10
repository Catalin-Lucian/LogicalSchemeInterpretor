using LogicalSchemeInterpretor.Commands;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor.CommandConfig
{
    interface ICommandConfiguration
    {
        void AddElement(ICommand command);
        void RemoveElement(ICommand command);
        void BindElementFirst(ICommand father, ICommand firstSon);
        void BindElementSecond(ICommand father, ICommand secondSon);
        public Hashtable Graph
        {
            get; set;
        }

        public List<ICommand> CommandList
        {
            get; set;
        }
    }
}
