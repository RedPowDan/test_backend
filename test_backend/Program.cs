using System;
using System.Linq;

namespace test_backend
{
    public class Program
    {
        public static int get_sum_min_numbers(int[] mass, int count_numbers_min_sum)
        {
            if (mass == null)
            {
                throw new ArgumentNullException("Null on mass");
            }else if (mass.Length == 0)
            {
                throw new ArgumentException("Empty mass");
            }

            var min_mass = mass.Take(count_numbers_min_sum).ToArray();

            Array.Sort(min_mass);
            Array.Reverse(min_mass);

            for(int i = 2; i < mass.Length; i++)
            {
                if(min_mass[0] > mass[i])
                {
                    min_mass[0] = mass[i];
                    Array.Sort(min_mass);
                    Array.Reverse(min_mass);
                }
            }

            return min_mass.Sum();
        }
        static void Main(string[] args)
        {
            int[] test_mass = new int[100];
            var result = get_sum_min_numbers(test_mass, 2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
