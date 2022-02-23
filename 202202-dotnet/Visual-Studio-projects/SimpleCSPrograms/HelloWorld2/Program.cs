using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld2
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello\nWorld");
            //System.Console.WriteLine("\"Hello\" from C#\r\"World\" of  ");
            a = 5;
            b = 5;

            c = a++ * ++b;

            Console.WriteLine("a={0}\tb={1}\tc={2}", a, b, c);

        }
    }
}
