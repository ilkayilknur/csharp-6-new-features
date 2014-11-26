namespace NullConditionalOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            string personName = null;
            Person person = null;
            //Before C# 6.0
            if (person != null)
            {
                personName = person.Name;
            }

            //After C# 6.0
            personName = person?.Name;
        }
    }

    class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
    }
}
