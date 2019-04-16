using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringVsStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "You can see";
            Console.WriteLine("string: "+myString);
            Console.WriteLine("hashCode: " + myString.GetHashCode().ToString());
            myString += " difference between";
            Console.WriteLine("string: " + myString);
            Console.WriteLine("hashCode: " + myString.GetHashCode().ToString());
            myString += " string and stringbuilder.";
            Console.WriteLine("string: " + myString);
            Console.WriteLine("hashCode: " + myString.GetHashCode().ToString());

            StringBuilder myStringBuilder = new StringBuilder();
            myStringBuilder.Append("You can see");
            Console.WriteLine("stringBuilder: " + myStringBuilder);
            Console.WriteLine("hashCode: " + myStringBuilder.GetHashCode().ToString());
            myStringBuilder.Append(" difference between");
            Console.WriteLine("stringBuilder: " + myStringBuilder);
            Console.WriteLine("hashCode: " + myStringBuilder.GetHashCode().ToString());
            myStringBuilder.Append(" string and stringbuilder.");
            Console.WriteLine("stringBuilder: " + myStringBuilder);
            Console.WriteLine("hashCode: " + myStringBuilder.GetHashCode().ToString());


            Console.ReadKey();
        }
    }
}
