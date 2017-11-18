using System.Collections.Generic;
using Visitor.Visitors;

namespace Visitor.ObjectStructure
{
    public class Document
    {
        private readonly List<DocumentPart> _mParts;

        public Document(params DocumentPart[] documents)
        {
            _mParts = new List<DocumentPart>();
            _mParts.AddRange(documents);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (DocumentPart part in this._mParts) part.Accept(visitor);
        }
    }
}
