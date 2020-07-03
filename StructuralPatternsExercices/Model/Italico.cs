using System.Text;

namespace StructuralPatternsExercices.Model
{
    public class Italico : ElementBase
    {
        public Italico() : base() { }
        public Italico(IElement element) : base(element) { }
        public Italico(IElement[] elements) : base(elements) { }

        public override string ToHtml()
        {
            var html = new StringBuilder("<i");
            foreach (var attribute in attributes)
            {
                html.Append($" {attribute.Key}='{attribute.Value}'");
            }

            html.Append(">");
            children.ForEach(q => html.Append(q.ToHtml()));
            html.Append("</i>");

            return html.ToString();
        }
    }
}
