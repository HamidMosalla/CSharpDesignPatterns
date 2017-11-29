namespace Interpreter.Expression
{
    public class AddExpression : IExpression
    {
        readonly IExpression leftExpression;
        readonly IExpression rightExpression;

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