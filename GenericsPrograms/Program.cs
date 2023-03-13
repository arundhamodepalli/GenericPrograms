namespace GenericsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxInt;
            double maxFloat;
            String maxString;
            //To find Greatest among 3 number
            //T.C1 Max at first Position
            maxInt = MaximumInteger.MaxNumCheck(4, 3, 2);
            Console.WriteLine("The greater number among 4,3,2 is " + maxInt);
            //T.C2 Max at second Position
            maxInt = MaximumInteger.MaxNumCheck(2, 5, 3);
            Console.WriteLine("The greater number among 2, 5, 3 is " + maxInt);
            //T.C3 Max at third Positon
            maxInt = MaximumInteger.MaxNumCheck(2, 6, 8);
            Console.WriteLine("The greater number among 2, 6, 8 is " + maxInt);

            Console.WriteLine("The greatest among float values");
            //Maximum among three float Integers
            //T.C1 Max at first Position
            maxFloat = MaximumInteger.MaximumFloatCheck(4.4, 2.2, 3.3);
            Console.WriteLine("The greater Float among 4.4,2.2,3.3 is " + maxFloat);
            //T.C2 Max at second Position
            maxFloat = MaximumInteger.MaximumFloatCheck(4.4, 5.5, 3.3);
            Console.WriteLine("The greater Float among 4.4, 5.5, 3.3 is " + maxFloat);
            //T.C3 Max at third Position
            maxFloat = MaximumInteger.MaximumFloatCheck(4.4, 2.2, 6.6);
            Console.WriteLine("The greater Float among 4.4, 2.2, 6.6 is " + maxFloat);

            Console.WriteLine("The greatest among Strings");
            //Maximum among three Strings
            //T.C1 Max at first Position
            maxString = MaximumInteger.MaximumStringCheck("c", "b", "a");
            Console.WriteLine("The greater Float among \"a\", \"b\", \"c\" is " + maxString);
            //T.C2 Max at second Position
            maxString = MaximumInteger.MaximumStringCheck("D", "F", "E");
            Console.WriteLine("The greater Float among \"D\", \"F\", \"E\" is " + maxString);
            //T.C3 Max at third Position
            maxString = MaximumInteger.MaximumStringCheck("J", "K", "L");
            Console.WriteLine("The greater Float among \"J\", \"K\", \"L\" is " + maxString);




        }
    }
}