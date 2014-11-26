namespace AutoPropertyInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class BeforeCSharp6
    {
        private readonly string foo = "bar";
        //Readonly property
        public string Foo
        {
            get
            {
                return foo;
            }
        }
        public string Name { get; set; }

        //getter only properties not allowed before C# 6.0
        //public string Foo { get; }

        public BeforeCSharp6()
        {
            //Initializing default value
            Name = "Ilkay";
        }
    }

    public class CSharp6AutoPropertyInitializers
    {
        public string Name { get; set; } = "Ilkay";
        public string Foo { get; } = "bar";
    }
}
