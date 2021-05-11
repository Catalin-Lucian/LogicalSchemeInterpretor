using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor
{
    public interface ICommandType
    {
        public void Execute();
        public bool GetNext();
    }
}
