namespace Interpreter.Expression
{
    public class AddExpression : IExpression
    {
        readonly IExpression _leftExpression;
        readonly IExpression _rightExpression;

        public AddExpression(IExpression left, IExpression right)
        {
            _leftExpression = left;
            _rightExpression = right;
        }

        int IExpression.Interpret()
        {
            return _leftExpression.Interpret() + _rightExpression.Interpret();
        }
    }
}