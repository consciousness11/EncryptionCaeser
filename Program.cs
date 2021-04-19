using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionCaeser
{
    class Program
    {
        
            public static char ciper(char c,int k)
            {
                if (!char.IsLetter(c)) return c;

                char convCh = char.IsUpper(c) ? 'A' : 'a';
                return (char)((((c + k) - convCh) % 26) + convCh);

            }

            public static string Encrypt(string input,int key)
            {
                string output = string.Empty;
                foreach (char c in input)
                    output += ciper(c, key);
                return output;
            }

            public static string Decrypt(string input, int key)
            {
                return Encrypt(input, 26 - key);
            }

            static void Main(string[] args) {
                Console.WriteLine("Type a string to encrypt:");
                Console.WriteLine("\n");
                string inpString = Console.ReadLine();
                Console.WriteLine("Type a key to encrypt:");
                Console.WriteLine("\n");
                int key;
                key = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                Console.WriteLine("Encrypted string");
                string encrypted = Encrypt(inpString, key);
                Console.WriteLine(encrypted);

                Console.WriteLine("\n");
                Console.WriteLine("Decrypted ");
                string t = Decrypt(encrypted, key);
            Console.WriteLine(t);
            Console.ReadLine();
            }



        }
    }

