using System.Text;

namespace StructuralPatternsExercices.Model
{
    public class P : ElementBase
    {
        public P() : base() { }
        public P(IElement element) : base(element) { }
        public P(IElement[] elements) : base(elements) { }

        public override string ToHtml()
        {
            var html = new StringBuilder("<p");
            foreach (var attribute in attributes)
            {
                html.Append($" {attribute.Key}='{attribute.Value}'");
            }

            html.Append(">");
            children.ForEach(q => html.Append(q.ToHtml()));
            html.Append("</p>");

            return html.ToString();
        }
    }
}
