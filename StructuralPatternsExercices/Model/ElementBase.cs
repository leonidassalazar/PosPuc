using System.Collections.Generic;

namespace StructuralPatternsExercices.Model
{
    public abstract class ElementBase : IElement
    {

        protected List<IElement> children;
        protected Dictionary<string, string> attributes;

        protected ElementBase()
        {
            children = new List<IElement>();
            attributes = new Dictionary<string, string>();
        }

        protected ElementBase(IElement element)
        {
            children = new List<IElement>();
            attributes = new Dictionary<string, string>();
            AddElement(element);
        }

        protected ElementBase(IElement[] elements)
        {
            children = new List<IElement>();
            attributes = new Dictionary<string, string>();
            foreach (var element in elements)
            {
                AddElement(element);
            }
        }

        public IElement AddElement(IElement element)
        {
            children.Add(element);

            return this;
        }

        public IElement AddAttribute(string name, string value)
        {
            attributes.Add(name, value);

            return this;
        }

        public abstract string ToHtml();
    }
}
