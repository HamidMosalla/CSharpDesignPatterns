namespace Interpreter.Expression
{
    public class NumberExpression : IExpression
    {
        readonly int _number;

        public NumberExpression(int i)
        {
            _number = i;
        }

        int IExpression.Interpret()
        {
            return _number;
        }
    }
}