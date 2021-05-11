
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor
{
    public interface ICommand
    {
        public void Execute();
        public ICommandType CommandType{
            get; set;
        }

    }
}
