using Visitor.ObjectStructure;
using Visitor.Visitors;

namespace Visitor.Elements
{
    public class Hyperlink : DocumentPart
    {
        public string Url { get; set; }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
