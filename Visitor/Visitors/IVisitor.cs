using Visitor.Elements;

namespace Visitor.Visitors
{
    public interface IVisitor
    {
        void Visit(PlainText docPart);
        void Visit(BoldText docPart);
        void Visit(Hyperlink docPart);
    }
}
