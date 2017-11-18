using Visitor.Visitors;

namespace Visitor.ObjectStructure
{
    public abstract class DocumentPart
    {
        public string Text { get; set; }
        public abstract void Accept(IVisitor visitor);
    }
}
