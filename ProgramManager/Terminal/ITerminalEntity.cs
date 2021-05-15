using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalSchemeInterpretor.Terminal
{
    interface ITerminalEntity
    {
        public string ReadFromTerminal();
        public void WriteToTerminal(string text);
    }
}
