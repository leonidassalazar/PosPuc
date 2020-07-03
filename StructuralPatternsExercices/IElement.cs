namespace StructuralPatternsExercices
{
    public interface IElement
    {
        IElement AddElement(IElement element);
        IElement AddAttribute(string name, string value);
        string ToHtml();
    }
}
