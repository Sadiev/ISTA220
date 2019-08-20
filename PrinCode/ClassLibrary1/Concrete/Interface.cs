using CsAst.Abstract;

namespace CsAst
{
    public class Interface : CodeElement, INamespaceable
    {
        public Interface(string name, Visibility visibility=Visibility.Private) :base (name)
        {
            //Name = name;
            Visibility = visibility;
        }

       // public string Name { get; set ; }
        public Visibility Visibility { get; set; }

        public override string Display()
        {
            return $"{Util.DisplayVisibility(Visibility)}interface {Name} {{}}";
        }
    }
}
