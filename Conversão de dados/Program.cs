using System;

namespace ConvertendoStrToInt
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string s = "10000";
            int i;
            
            i = int.Parse(s);

            int x = i + 10;
            Console.WriteLine(x);
        }
    }
}
