using StructuralPatternsExercices.Model;
using System;

namespace StructuralPatternsExercices
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = new Negrito(new Italico(new Span("meu texto estiloso!")));
            Console.WriteLine(html.ToHtml());

            var html2 =
                new Negrito(new Italico(new Span("meu texto estiloso!").AddAttribute("class", "banana"))).ToHtml();
            Console.WriteLine(html2);
            Console.ReadKey();
        }
    }
}
