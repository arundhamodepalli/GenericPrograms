using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPrograms
{
    internal class MaximumInteger
    {
        //Return Maximum values out of three
        public static int MaxNumCheck(int firstValue, int secondValue, int thirdValue)
        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("FirstNumber,Second Number , Third Number are same");


        }

        public static double MaxFloatCheck(double firstValue, double secondValue, double thirdValue)
        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(secondValue) > 0 && thirdValue.CompareTo(firstValue) > 0)
            {
                return thirdValue;
            }
            throw new Exception("FirstNumber,Second Number , Third Number are same");


        }
        //Compare String type 
        public static String MaxStringCheck(String firstString, String secondString, String thirdString)
        {
            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||
                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||
                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||
                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            throw new Exception("FirstString,Second String , Third String are same");

        }

        public static void GenricMethod<T>(T[] ar)
        {
            Array.Sort(ar);
            Array.Reverse(ar);
            Console.WriteLine("The greatest among the numbers are " + ar[0]);


        }
    }

    public class NonGenerics
    {

        public NonGenerics()
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
            maxFloat = MaximumInteger.MaxFloatCheck(4.4, 2.2, 3.3);
            Console.WriteLine("The greater Float among 4.4,2.2,3.3 is " + maxFloat);
            //T.C2 Max at second Position
            maxFloat = MaximumInteger.MaxFloatCheck(4.4, 5.5, 3.3);
            Console.WriteLine("The greater Float among 4.4, 5.5, 3.3 is " + maxFloat);
            //T.C3 Max at third Position
            maxFloat = MaximumInteger.MaxFloatCheck(4.4, 2.2, 6.6);
            Console.WriteLine("The greater Float among 4.4, 2.2, 6.6 is " + maxFloat);

            Console.WriteLine("The greatest among Strings");
            //Maximum among three Strings
            //T.C1 Max at first Position
            maxString = MaximumInteger.MaxStringCheck("c", "b", "a");
            Console.WriteLine("The greater Float among \"a\", \"b\", \"c\" is " + maxString);
            //T.C2 Max at second Position
            maxString = MaximumInteger.MaxStringCheck("D", "F", "E");
            Console.WriteLine("The greater Float among \"D\", \"F\", \"E\" is " + maxString);
            //T.C3 Max at third Position
            maxString = MaximumInteger.MaxStringCheck("J", "K", "L");
            Console.WriteLine("The greater Float among \"J\", \"K\", \"L\" is " + maxString);

        }

    }

    public class WithGenerics
    {

        public WithGenerics()
        {
            Console.WriteLine("-------Using generics---------");
            //T.C1 comparison of Integer using generic
            int[] intArray = new int[] { 1, 2, 3, 4, 5 };
            MaximumInteger.GenricMethod<int>(intArray);
            double[] dbArray = new double[] { 1.3, 2.5, 1.2, 1.28, 1 };
            MaximumInteger.GenricMethod<double>(dbArray);
            /* int[] intArray = new int[] { 1, 2, 3, 4, 5 };
             MaximumNumberCheck.GenricMethod<int>(intArray);*/
            //Using Generic method
            //Find maximum among integer 
            GenericMaximum<int> intGenric = new GenericMaximum<int>(2, 3, 4);
            Console.WriteLine("The greatest among 2,3,4 is " + intGenric.MaxMethod());
            //Find maximum among double
            GenericMaximum<double> doubleGenric = new GenericMaximum<double>(4.4, 3.8, 1.1);
            Console.WriteLine("The greatest among 2,3,4 is " + doubleGenric.MaxMethod());

        }

    }

    public class MultipleInputs
    {

        public MultipleInputs()
        {

            Console.WriteLine("----Max Among Multiple Input -----");
            Console.WriteLine("Enter the total number of elements");
            int arl = Convert.ToInt32(Console.ReadLine());
            double[] ar = new double[arl];
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("Enter number" + (i + 1));
                ar[i] = Convert.ToDouble(Console.ReadLine());

            }
            MaximumInteger.GenricMethod<double>(ar);



        }

    }

    public class GenericMaximum<T> where T : IComparable
    {
        public T firstValue, secondValue, thirdValue;
        public GenericMaximum(T firstValue, T secondValue, T thirdValue)
        {

            this.firstValue = firstValue;
            this.secondValue = secondValue;
            this.thirdValue = thirdValue;



        }

        public static T MaxValue(T firstValue, T secondValue, T thirdValue)
        {

            if (firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) >= 0 && firstValue.CompareTo(thirdValue) > 0 ||
                firstValue.CompareTo(secondValue) > 0 && firstValue.CompareTo(thirdValue) >= 0)
            {
                return firstValue;
            }
            if (secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) >= 0 && secondValue.CompareTo(thirdValue) > 0 ||
                secondValue.CompareTo(firstValue) > 0 && secondValue.CompareTo(thirdValue) >= 0)
            {
                return secondValue;
            }
            if (thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) >= 0 && thirdValue.CompareTo(secondValue) > 0 ||
                thirdValue.CompareTo(firstValue) > 0 && thirdValue.CompareTo(secondValue) >= 0)
            {
                return thirdValue;
            }
            return default;

        }
        public T MaxMethod()
        {

            T max = GenericMaximum<T>.MaxValue(this.firstValue, this.secondValue, this.thirdValue);

            return max;

        }


    }

    //Print Max Output Added

    public class GenericPrintMax<T>
    {

        public GenericPrintMax()
        {
            Console.WriteLine("Enter the total number of elements");
            int arl = Convert.ToInt32(Console.ReadLine());
            double[] ar = new double[arl];
            for (int i = 0; i < ar.Length; i++)
            {
                Console.WriteLine("Enter number" + (i + 1));
                ar[i] = Convert.ToDouble(Console.ReadLine());

            }
            PrintMax(ar);



        }


        public static void PrintMax<T>(T[] ar)
        {
            Array.Sort(ar);
            Array.Reverse(ar);
            Console.WriteLine("The greates number is " + ar[0]);

        }

    }
}