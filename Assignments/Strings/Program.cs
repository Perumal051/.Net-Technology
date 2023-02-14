using System;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[]args)
        {
            
            Console.WriteLine("Enter the input string");
            string name = Console.ReadLine();
            Console.WriteLine("The output string is" + name.ToLower());

            // 2. Converting Text to SMS Language
                string msg = Console.ReadLine();
                if (msg.Contains("yes"))
                {
                    msg=msg.Replace("yes", "s");
                }
                if (msg.Contains("why"))
                {
                    msg=msg.Replace("why", "y");
                }
                if (msg.Contains("you"))
                {
                    msg=msg.Replace("you", "u");
                }
                if (msg.Contains("to"))
                {
                    msg=msg.Replace("to", "2");
                }
                Console.WriteLine(msg);

            // 3.String API : split() : Illustration
                Console.WriteLine("Enter the string : ");
                string str = Console.ReadLine();
                string[] strList = str.Split(" ");
                Console.WriteLine("The words in the string are : ");
                foreach(string  item in strList)
                {
                    Console.WriteLine(item);
                }
        }
    }
}
