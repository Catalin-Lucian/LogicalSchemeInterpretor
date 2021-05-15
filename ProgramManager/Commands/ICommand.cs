

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
