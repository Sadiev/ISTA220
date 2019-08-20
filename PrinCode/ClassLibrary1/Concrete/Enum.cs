namespace ConsoleApp2
{
    public class Enum : INamespaceable
    {
        public Enum(string name, Visibility visibility=Visibility.Private)
        {
            Name = name;
            Visibility = visibility;
        }

        public string Name { get; set; }
        public Visibility Visibility { get; set; }

        public string Display()
        {
            return $"{Util.DisplayVisibility(Visibility)}enum {Name} {{}};";
        }
    }
}
