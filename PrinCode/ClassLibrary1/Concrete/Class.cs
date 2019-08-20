namespace ConsoleApp2
{
    public class Class : INamespaceable
    {
        public Class(string name, Visibility visibility=Visibility.Private)
        {
            Name = name;
            Visibility = visibility;
        }

        //string Name;

        public string Name { get; set; }
        public Visibility Visibility { get; set; }

        public string Display()
        {
            return $"{Util.DisplayVisibility(Visibility)}class {Name} {{}}";
        }
    }
}
