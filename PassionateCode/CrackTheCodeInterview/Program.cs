using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            StringUnique su = new StringUnique();
            Console.WriteLine(su.IsUniqueChars2("abcdef"));
            Console.WriteLine(su.IsUniqueChars2("aca"));
            Console.ReadLine();
        }
    }
}
