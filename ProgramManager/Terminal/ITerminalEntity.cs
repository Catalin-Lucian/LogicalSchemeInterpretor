
namespace LogicalSchemeInterpretor
{
    interface ITerminalEntity
    {
        public string ReadFromTerminal();
        public void WriteToTerminal(string text);
    }
}
