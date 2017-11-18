using System.Collections.Generic;
using Visitor.Visitors;

namespace Visitor.ObjectStructure
{
    public class Document
    {
        private List<DocumentPart> m_parts;

        public Document(params DocumentPart[] documents)
        {
            m_parts = new List<DocumentPart>();
            m_parts.AddRange(documents);
        }

        public void Accept(IVisitor visitor)
        {
            foreach (DocumentPart part in this.m_parts) part.Accept(visitor);
        }
    }
}
