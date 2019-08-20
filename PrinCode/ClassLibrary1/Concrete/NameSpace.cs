using System.Collections.Generic;

namespace ConsoleApp2
{
    public class NameSpace : INamed, IDisplayable
    {
        //string Name;

        List<INamespaceable> elements=new List<INamespaceable>();

        public NameSpace(string name)
        {
            Name = name;
        }

        public void AddNameSpaceElement(INamespaceable namespaceable)
        {
            elements.Add(namespaceable);
        }

        public string Name { get; set; }

        public string Display()
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
