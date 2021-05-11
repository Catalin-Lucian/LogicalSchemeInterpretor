
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor
{
    class Command : ICommand
    {
        private ICommandType _commandType;

        public Command(ICommandType commandType)
        {
            _commandType = commandType;
        }

        public ICommandType CommandType { 
            get => _commandType; 
            set => _commandType = value; 
        }

        public void Execute()
        {
            CommandType.Execute();
        }
    }
}
