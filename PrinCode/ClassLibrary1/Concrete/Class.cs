using CsAst.Abstract;

namespace CsAst
{
    public class Class : CodeElement, INamespaceable
    {
        public Class(string name, Visibility visibility=Visibility.Private) : base (name)
        {
           // Name = name;
            Visibility = visibility;
        }

        //string Name;

        //public string Name { get; set; }
        public Visibility Visibility { get; set; }

        public override string Display()
        {
            return $"{Util.DisplayVisibility(Visibility)}class {Name} {{}}";
        }
    }
}
