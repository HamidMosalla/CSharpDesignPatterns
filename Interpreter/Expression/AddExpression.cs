namespace Interpreter.Expression
{
    public class AddExpression : IExpression
    {
        IExpression leftExpression;
        IExpression rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            leftExpression = left;
            rightExpression = right;
        }

        int IExpression.Interpret()
        {
            return leftExpression.Interpret() + rightExpression.Interpret();
        }
    }
}