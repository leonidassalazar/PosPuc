using System.Text;

namespace StructuralPatternsExercices.Model
{
    public class Negrito : ElementBase
    {
        public Negrito() : base() { }
        public Negrito(IElement element) : base(element) { }
        public Negrito(IElement[] elements) : base(elements) { }

        public override string ToHtml()
        {
            var html = new StringBuilder("<b");
            foreach (var attribute in attributes)
            {
                html.Append($" {attribute.Key}='{attribute.Value}'");
            }

            html.Append(">");
            children.ForEach(q => html.Append(q.ToHtml()));
            html.Append("</b>");

            return html.ToString();
        }
    }
}
