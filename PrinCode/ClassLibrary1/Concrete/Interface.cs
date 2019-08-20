namespace ConsoleApp2
{
    public class Interface : INamespaceable
    {
        public Interface(string name, Visibility visibility=Visibility.Private)
        {
            Name = name;
            Visibility = visibility;
        }

        public string Name { get; set ; }
        public Visibility Visibility { get; set; }

        public string Display()
        {
            return $"{Util.DisplayVisibility(Visibility)}interface {Name} {{}}";
        }
    }
}
