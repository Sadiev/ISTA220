using CsAst.Abstract;

namespace CsAst
{
    public class Enum : CodeElement, INamespaceable
    {
        public Enum(string name, Visibility visibility=Visibility.Private) : base (name)
        {
            //Name = name;
            Visibility = visibility;
        }

        //public string Name { get; set; }
        public Visibility Visibility { get; set; }

        public override string Display()
        {
            return $"{Util.DisplayVisibility(Visibility)}enum {Name} {{}};";
        }
    }
}
