﻿namespace LogicalSchemeInterpretor
{
    public interface IOperator
    {
        double ExecuteOperation(IExpression firstTerm, IExpression secondTerm);
    }
}