namespace GenericsPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result;
            //To find Greatest among 3 number
            //T.C1 Max at first Position
            result = MaximumInteger.MaxNumCheck(4, 3, 2);
            Console.WriteLine("The greater number is " + result);
            //T.C2 Max at second Position
            result = MaximumInteger.MaxNumCheck(2, 5, 3);
            Console.WriteLine("The greater number is " + result);
            //T.C3 Max at third Positon
            result = MaximumInteger.MaxNumCheck(2, 6, 8);
            Console.WriteLine("The greater number is " + result);

        }
    }
}