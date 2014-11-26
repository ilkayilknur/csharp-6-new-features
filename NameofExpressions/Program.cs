using System;

namespace NameofExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo("Test");
        }

        static void Foo(string bar)
        {
            //Before C# 6.0 
            if (String.IsNullOrEmpty(bar))
            {
                //Using parameter name as string literal. It's error prone.
                //if you change parameter name, you may forget to change this string. Runtime error.
                throw new ArgumentNullException("bar");
            }

            //After C# 6.0 
            if (String.IsNullOrEmpty(bar))
            {
                //If you change parameter name, code doesn't compile and you realize the error in development time.
                throw new ArgumentNullException(nameof(bar));
            }
        }
    }
}
