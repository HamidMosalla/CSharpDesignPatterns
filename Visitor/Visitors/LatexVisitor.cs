using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Elements;

namespace Visitor.Visitors
{
    public class LatexVisitor : IVisitor
    {
        public string Output
        {
            get { return this.m_output; }
        }
        private string m_output = "";

        public void Visit(PlainText docPart)
        {
            this.m_output += docPart.Text;
        }

        public void Visit(BoldText docPart)
        {
            this.m_output += "\\textbf{" + docPart.Text + "}";
        }

        public void Visit(Hyperlink docPart)
        {
            this.m_output += "\\href{" + docPart.Url + "}{" + docPart.Text + "}";
        }
    }
}
