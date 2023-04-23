using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace palindromno
{
    class demo
    {
        int temp, rem, sum, no;
       public void get()
        {
            Console.WriteLine("enter the number");
            no = Convert.ToInt32(Console.ReadLine());
        }
        public void show()
        {
            temp = no; 
            while (no > 0)
            {
                rem = no % 10;
                sum = (sum * 10) + rem;
                no = no / 10;
            }
            if (temp == sum)
            {
                Console.WriteLine("given number is palindrome");
            }
            else
            {
                Console.WriteLine("given number is not palindrome");
            }
        }
    }
    class palindrom
    {
        static void Main(string[] args)
        {

            demo d1=new demo();
            d1.get();
            d1.show();
            Console.ReadLine();
        }
    }
}
