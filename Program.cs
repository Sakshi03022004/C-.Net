using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2palindromeno
{
     class demo
    {
        int no, r, sum, temp;
        public void read()
        {
            Console.WriteLine("enter the number");
            no = Convert.ToInt32(Console.ReadLine());
            temp = no;
        }
       public void show()
        {
            sum = 0;
            while (no > 0)
            {
                r = no % 10;
                sum = sum * 10 + r;
                no = no / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("number is palindrom");
            }
            else
            {
                Console.WriteLine("number is not palindrom");
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

