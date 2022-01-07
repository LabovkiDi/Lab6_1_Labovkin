using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_1_Labovkin
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string s = Console.ReadLine();
            string[] words = s.Split(' ');
            string Maxwl = " ";
            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > Maxwl.Length)
                    Maxwl = words[i];
            }
            Console.WriteLine("Самое длинное слово:{0}", Maxwl);
            Console.ReadKey();
        }
    }
}
