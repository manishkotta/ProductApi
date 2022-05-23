using System;

namespace LogicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            Console.WriteLine("Wnter String to Reverse");
            var str = Console.ReadLine();
            p.Reverse(str);
            Console.WriteLine("End of String reverse Program");

            p.FizzBuzz();

            Console.ReadLine();
        }

        public void Reverse(string str)
        {
            string newString = "";
            for(int j = str.Length - 1; j >= 0; j--)
            {
                newString += str[j];
            }
            Console.WriteLine(newString);
        }

        public void FizzBuzz()
        {
            for(int i=0; i< 100; i++)
            {
                string str = "";
                if(i/3 == 0)
                {
                    str += "fizz"; 
                }
                if(i/5 == 0)
                {
                    str += "buzz";
                }
                Console.WriteLine(str);
            }
        }
    }
}
