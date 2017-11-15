using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word or phrase to be reversed!");
            String input = Console.ReadLine();
            String reversed = "";
            for (int i = (input.Length - 1); i > -1; i--)
            {
                reversed += input[i];
            }

            Console.WriteLine("Here is your reversal!");
            Console.Write(reversed);
            Console.Read();
        }
    }
}
