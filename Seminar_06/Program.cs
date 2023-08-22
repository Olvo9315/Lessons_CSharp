using System;
using System.Diagnostics;


class Program
{
    static void Main(string[] args)
    {

        Stopwatch stopwatch = new Stopwatch();
        DateTime inicio = DateTime.Now;
        Console.WriteLine("Inicio: " + inicio.ToString());
        stopwatch.Start();
        int[] array = GetArray(10000000, 0, 100000);
        TimeSpan timeTrans1 = stopwatch.Elapsed;
        Console.WriteLine("arrayGen: " + timeTrans1.TotalSeconds + " s");
        //Console.WriteLine(string.Join(" ", array));

        Stopwatch stopwatch1 = new Stopwatch();
        stopwatch1.Start();
        int itr = 0;
        while (itr < 60)
        {
            int[] reversArray = ReversArray1(array);
            itr++;
        }
        stopwatch1.Stop();
        TimeSpan timeTrans2 = stopwatch1.Elapsed;
        Console.WriteLine("Revers1: " + timeTrans2.TotalSeconds + " s");
        //Console.WriteLine(string.Join(" ", reversArray));

        Stopwatch stopwatch2 = new Stopwatch();
        stopwatch2.Start();
        int itr1 = 0;
        while (itr1 < 60)
        {
            ReversArray2(array);
            itr1++;
        }
        TimeSpan timeTrans3 = stopwatch2.Elapsed;
        Console.WriteLine("Revers2: " + timeTrans3.TotalSeconds + " s");
        //Console.WriteLine(string.Join(" ", array));
        DateTime fin = DateTime.Now;
        Console.WriteLine("Inicio: " + fin.ToString());


        int[] GetArray(int size, int minValue, int maxValue)
        {
            int[] res = new int[size];
            for (int i = 0; i < size; i++)
            {
                res[i] = new Random().Next(minValue, maxValue + 1);
            }
            return res;
        }

        int[] ReversArray1(int[] inArray)
        {
            int[] result = new int[inArray.Length];
            for (int i = 0; i < inArray.Length; i++)
            {
                result[i] = inArray[inArray.Length - 1 - i];
            }
            return result;
        }

        void ReversArray2(int[] inArray)
        {
            for (int i = 0; i < inArray.Length / 2; i++)
            {
                int k = inArray[i];
                inArray[i] = inArray[inArray.Length - i - 1];
                inArray[inArray.Length - i - 1] = k;
            }
        }
    }
}