using System.Collections.Generic;

namespace IndexInitializers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Before C# 6.0
            Dictionary<int, string> memberNames = new Dictionary<int, string>();
            memberNames[0] = "Foo";
            memberNames[1] = "Bar";
            memberNames[2] = "Name";

            //After C# 6.0
            Dictionary<int, string> memberNamesV2 = new Dictionary<int, string>()
            {
                [0] = "Foo",
                [1] = "Bar",
                [2] = "Name"
            };
        }
    }
}
