using System;

namespace Ladder
{
    enum Step
    {
        One = 1,
        Two = 2,
        Three = 3,
    }

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Number of ways: {0}", Count(n));

            Console.ReadLine();
        }

        public static int Count(int n)
        {
            if (n == (int)Step.One)
            {
                return 1;
            }

            if (n == (int)Step.Two)
            {
                return 2;
            }

            if (n == (int)Step.Three)
            {
                return 4;
            }

            return Count(n - 1) + Count(n - 2) + Count(n - 3);
        }

        //public static int Count(int n)
        //{
        //    int[] arr = new int[3];
        //    arr[0] = 1;
        //    arr[1] = 2;
        //    arr[2] = 4;

        //    for (int i = 3; i < n; i++)
        //    {
        //        arr[i%3] = arr[0] + arr[1] + arr[2];
        //    }

        //    return arr[(n - 1)%3];
        //}
    }
}
