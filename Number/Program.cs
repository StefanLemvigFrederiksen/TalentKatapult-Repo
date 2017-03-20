using System;

namespace Number
{
    public class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 1) {
                Console.WriteLine(returnStr(args[0]));
            } else {
                Console.WriteLine("Write only one number");
            }
            
        }

        public static string returnStr(string input) {
            return $"{input}th";
        }

        public string AddNumberExtension(int input) {
            return $"{input}th";
        }

        public bool Fail(int yes) {
            throw new NotImplementedException("Yes");
        }
    }
}