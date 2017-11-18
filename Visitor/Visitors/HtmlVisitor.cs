using Visitor.Elements;

namespace Visitor.Visitors
{
    public class HtmlVisitor : IVisitor
    {
        public string Output
        {
            get { return this.m_output; }
            set { this.m_output = value; }
        }

        private string m_output = "";

        public void Visit(PlainText docPart)
        {
            this.m_output += docPart.Text;
        }

        public void Visit(BoldText docPart)
        {
            this.m_output += "<b>" + docPart.Text + "</b>";
        }

        public void Visit(Hyperlink docPart)
        {
            this.m_output += "<a href=\"" + docPart.Url + "\">" + docPart.Text + "</a>";
        }
    }
}
