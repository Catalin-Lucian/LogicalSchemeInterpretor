namespace LogicalSchemeInterpretor
{
    public interface IRelationalOperator
    {
        bool ExecuteCondition(IExpression firstExpression, IExpression secondExpression);
    }
}
