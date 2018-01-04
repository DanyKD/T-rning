using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tärning
{
    class Tärning
    {       
        public int KastaTärning()
        {
            Random rnd = new Random();                       
            return rnd.Next(1,7);            
        }
        public static int Gånger()
        {
            Newtry:
            Console.WriteLine("Please enter the number of times:");
            string gånger=Console.ReadLine();
            int x;            
            try
            {
                x = Convert.ToInt32(gånger);
            }
            catch
            {
                Console.WriteLine("please enter a number:");
                goto Newtry;
            }
            return x;
        }
        public bool Condition(int a,int b,int c)
        {
            if ((a + b + c == 1000) && (a < b) && (b < c)&&(a+b==c))
            {
                return true;
            }
            else
                return false;
        }
        public void Övning3()
        {
            int a, b, c;
            do
            {
                Random ran = new Random();
                a = ran.Next(1, 1000);
                b = ran.Next(1, 1000);
                c = ran.Next(1, 1000);
                Console.Write("a: "+a+" b: "+b+" c: "+c);
                Console.WriteLine();
            } while (Condition(a, b, c) == false);
            Console.Write("a: " + a + " b: " + b + " c: " + c);
        }

    }
}
