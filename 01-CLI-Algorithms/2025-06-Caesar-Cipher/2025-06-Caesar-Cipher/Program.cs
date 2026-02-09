using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025_06_Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** Caesar Cipher ***");

            Console.WriteLine("Enter lowercase text: ");
            string input = Console.ReadLine();
            Console.WriteLine("Enter key: ");
            if (int.TryParse(Console.ReadLine(), out int key))
            {
                string encrypted = Encrypt(input, key);
                Console.WriteLine($"Encrypted text: {encrypted}");
            }
            else
            {
                Console.WriteLine("Invalid key.");
            }
        }
        static string Encrypt(string text, int key)
        {
            string result = "";

            foreach (char c in text)
            {
                if (c >= 'a' && c <= 'z')
                {
                    int charIndex = c - 'a';
                    int newIndex = (charIndex + (key % 26) + 26) % 26;
                    result += (char)('a' + newIndex);
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
