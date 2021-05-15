using LogicalSchemeInterpretor.Expressions;

namespace LogicalSchemeInterpretor.Operations
{
    public interface IRelationalOperator
    {
        bool ExecuteCondition(IExpression firstExpression, IExpression secondExpression);
        public string Operator_
        {
            get;
            set;
        }
    }
}
