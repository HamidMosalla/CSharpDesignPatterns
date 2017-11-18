using Visitor.ObjectStructure;
using Visitor.Visitors;

namespace Visitor.Elements
{
    public class PlainText : DocumentPart
    {
        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
