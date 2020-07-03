using System.Text;

namespace StructuralPatternsExercices.Model
{
    public class Span : ElementBase
    {
        private string _content;

        public Span(string content)
        {
            _content = content;
        }

        public override string ToHtml()
        {
            var html = new StringBuilder("<span");
            foreach (var attribute in attributes)
            {
                html.Append($" {attribute.Key}='{attribute.Value}'");
            }

            html.Append(">");
            html.Append(_content);
            html.Append("</span>");

            return html.ToString();
        }
    }
}
