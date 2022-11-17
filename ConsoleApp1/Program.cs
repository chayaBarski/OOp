using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //6
            Eabs e=new Eabs();
            e.print();
            Eabs1 e1 = new Eabs1();
            e.print();
            //7
            Ball b=new Ball();
            b.attach(b);
            b.anattach();
        }
       

    }
}
