using System.Collections.Generic;

namespace OldImplementation
{
    public abstract class DocumentPart
    {
        public string Text { get; private set; }
        public abstract string ToHTML();
        public abstract string ToPlainText();
        public abstract string ToLatex();
    }

    public class PlainText : DocumentPart
    {
        public override string ToHTML()
        {
            return this.Text;
        }
        public override string ToPlainText()
        {
            return this.Text;
        }
        public override string ToLatex()
        {
            return this.Text;
        }
    }

    public class BoldText : DocumentPart
    {
        public override string ToHTML()
        {
            return "<b>" + this.Text + "</b>";
        }
        public override string ToPlainText()
        {
            return "**" + this.Text + "**";
        }
        public override string ToLatex()
        {
            return "\\textbf{" + this.Text + "}";
        }
    }

    public class Hyperlink : DocumentPart
    {
        public string Url { get; private set; }

        public override string ToHTML()
        {
            return "<a href=\"" + this.Url + "\">" + this.Text + "</a>";
        }
        public override string ToPlainText()
        {
            return this.Text + " [" + this.Url + "]";
        }
        public override string ToLatex()
        {
            return "\\href{" + this.Url + "}{" + this.Text + "}";
        }
    }

    public class Document
    {
        private List<DocumentPart> m_parts;

        public string ToHTML()
        {
            string output = "";
            foreach (DocumentPart part in this.m_parts)
            {
                output += part.ToHTML();
            }
            return output;
        }

        public string ToPlainText()
        {
            string output = "";
            foreach (DocumentPart part in this.m_parts)
            {
                output += part.ToPlainText();
            }
            return output;
        }

        public string ToLatex()
        {
            string output = "";
            foreach (DocumentPart part in this.m_parts)
            {
                output += part.ToLatex();
            }
            return output;
        }
    }
}
