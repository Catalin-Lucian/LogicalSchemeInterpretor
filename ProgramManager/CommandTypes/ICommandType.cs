

namespace LogicalSchemeInterpretor.CommandTypes
{
    public interface ICommandType
    {
        public void Execute();
        public bool GetNext();
    }
}
