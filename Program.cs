using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._3_Finding_duplicates_in_an_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] number = { 1,2,3,5,8,1,1,3,8,10,6,2};
            Console.WriteLine("Duplicate Numbers");
            for (int i = 0; i < number.Length; i++) 
            {
                for (int j = i + 1; j < number.Length; j++) 
                {
                    if (number[i] == number[j]) 
                    {
                        Console.WriteLine($"{number[i]}");
                        break;
                    }
                }
            }
        }
    }
}
