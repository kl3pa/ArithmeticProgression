using System;

namespace ArithmeticProgression
{
    class Program
    {

        public static void PrintSeries(ISeries series, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(series.GetCurrent());
                series.MoveNext();
            }
        }

        public static void PrintIndexable(IIndexable indexable, int count)
        {
            for (int i = 1; i <= count; i++)
            {
                Console.WriteLine(indexable[i]);
            }
        }
        static void Main(string[] args)
        {

            ArithmeticProgression arith = new ArithmeticProgression(2, 7);
            GeometricProgression geom = new GeometricProgression(4, 7);

            PrintSeries(arith, 5);
            Console.WriteLine();
            PrintSeries(geom, 5);
            
        }

    }
}
