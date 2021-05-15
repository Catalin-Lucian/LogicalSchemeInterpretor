using LogicalSchemeInterpretor.Observer;
using System;
using System.Collections.Generic;

namespace LogicalSchemeInterpretor.Terminal
{
    class ConsoleObject : ITerminalEntity, IObserver
    {
        public void Notify(string text)
        {
            WriteToTerminal(text);
        }

        public string ReadFromTerminal()
        {
            return Console.ReadLine();
        }

        public void WriteToTerminal(string text)
        {
            Console.WriteLine(text);
        }
    }
}
