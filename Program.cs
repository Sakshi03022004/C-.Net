using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3_perfectno
{
        class demo
        {
        int no, r, sum=0;
        public void read()
        {
            Console.WriteLine("enter the number");
            no = Convert.ToInt32(Console.ReadLine());
            r = 1;
        }
       public void show()
        {
            while (r<no)
            {
                if (no % r == 0)
                {
                    sum = sum + r;
                }
                r = r + 1;
            }
            if (no== sum)
            {
                Console.WriteLine("number is perfect");
            }
            else
            {
                Console.WriteLine("number is not perfect");
            }
        }
    }

        class Program
        {
            static void Main(string[] args)
            {
                demo d1 = new demo();
                d1.read();
                d1.show();
                Console.ReadLine();
            }

        }
    }


        