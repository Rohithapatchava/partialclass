using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace partialclass
{
    partial class c
    {

    }
    partial class c
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            demo.c obj = new demo.c();
            obj.m();
        }
    }
    namespace demo
    {
        class c
        {
            public void m()
            {
                Console.WriteLine("hai");
            }
        }
    }
}
