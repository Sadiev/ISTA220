using CsAst.Abstract;
using System.Collections.Generic;

namespace CsAst
{
    public class NameSpace : CodeElement//, INamed, IDisplayable
    {
        //string Name;

        List<INamespaceable> elements=new List<INamespaceable>();

        public NameSpace(string name) : base (name)
        {
            //Name = name;
        }

        public void AddNameSpaceElement(INamespaceable namespaceable)
        {
            elements.Add(namespaceable);
        }

        public string Name { get; set; }

        public override string Display()
        {
            var output = $"namespace {Name}\n{{\n";
            foreach (var element in elements)
            {
                output += $"\t{element.Display()}\n";
            }
            output += "}\n";
            return output;
        }
    }
}
