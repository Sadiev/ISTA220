using CsAst.Abstract;
using System;

namespace CsAst
{
    class Program
    {
        static void Main(string[] args)
        {
            NameSpace consoleApp5 = new NameSpace("ConsoleApp5");

            consoleApp5.AddNameSpaceElement(new Enum("Visibility", Visibility.Public));

            consoleApp5.AddNameSpaceElement(new Interface("IDisplayable", Visibility.Public));
            consoleApp5.AddNameSpaceElement(new Interface("INamed", Visibility.Public));
            consoleApp5.AddNameSpaceElement(new Interface("IVisible", Visibility.Public));
            consoleApp5.AddNameSpaceElement(new Interface("INamespaceable", Visibility.Public));

            consoleApp5.AddNameSpaceElement(new Class("Interface"));
            consoleApp5.AddNameSpaceElement(new Class("Namespace"));
            consoleApp5.AddNameSpaceElement(new Class("Class"));
            consoleApp5.AddNameSpaceElement(new Class("Enum"));
            //consoleApp5.Name = "ConsoleApp5";

            Class program = new Class("Program");
            //program.Name = "Program";

            consoleApp5.AddNameSpaceElement(program);

            Console.WriteLine(consoleApp5.Display());

            PrintName(program);
        }

        static void PrintName(INamed named)
        {
            Console.WriteLine(named.Name);
        }
    }
}
