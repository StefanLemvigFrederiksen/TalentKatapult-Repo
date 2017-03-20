using System;

namespace Number
{
    public class Program
    {
        public Program() { }
        static void Main(string[] args)
        {
            if (args.Length == 1) {
                Program p = new Program();
                Console.WriteLine(p.AddNumberExtension(Convert.ToInt32(args[0])));
            } else {
                Console.WriteLine("Write only one number");
            }
            
        }

        public string AddNumberExtension(int input) {
            return $"{input}th";
        }

        public bool Fail(int yes) {
            throw new NotImplementedException("Yes");
        }
    }
}