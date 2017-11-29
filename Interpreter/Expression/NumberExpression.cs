namespace Interpreter.Expression
{
    public class NumberExpression : IExpression
    {
        int number;
        public NumberExpression(int i)
        {
            number = i;
        }

        int IExpression.Interpret()
        {
            return number;
        }
    }
}