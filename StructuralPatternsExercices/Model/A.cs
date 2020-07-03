using System.Text;

namespace StructuralPatternsExercices.Model
{
    public class A : ElementBase
    {
        public A() : base() { }
        public A(IElement element) : base(element) { }
        public A(IElement[] elements) : base(elements) { }

        public override string ToHtml()
        {
            var html = new StringBuilder("<a");
            foreach (var attribute in attributes)
            {
                html.Append($" {attribute.Key}='{attribute.Value}'");
            }

            html.Append(">");
            children.ForEach(q => html.Append(q.ToHtml()));
            html.Append("</a>");

            return html.ToString();
        }
    }
}
