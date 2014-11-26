using System;

namespace ExpressionBodiedFunctionMembers
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo foo = new Foo();

            Console.WriteLine(foo.GetFullName("Ilkay", "Ilknur"));
            Console.WriteLine(foo.GetFullNameV2("Ilkay", "Ilknur"));
            Console.WriteLine(foo.Bar);
        }
    }

    public class Foo
    {
        //Declaring getter only property using expression bodied member
        public string Bar => "Bar";

        //Before C# 6.0
        public string GetFullName(string name, string surname)
        {
            return name + surname;
        }

        //After C# 6.0
        public string GetFullNameV2(string name, string surname) => name + surname;
    }
}
