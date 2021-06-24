using System;
using System.Diagnostics;
using System.Text;

namespace UsingString
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            // test avec string
            string s = string.Empty;
            sw.Start();
            for (int i=0;i<200000;i++)
            {
                s = s + "a";
            }
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            // test avec stringBuilder
            StringBuilder sb = new StringBuilder();
            sw.Restart();
            for (int i = 0; i < 200000; i++)
            {
                sb.Append("a");
            }
            s = sb.ToString();
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
