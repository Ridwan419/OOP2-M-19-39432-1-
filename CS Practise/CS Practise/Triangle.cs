using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practise
{
class Triangle
    {
        private int x, y, z;
        public Triangle(int x, int y, int z)
         {
             this.x = x;
             this.y = y;
             this.z = z;
         }
        public  void ShowInfo()
        {
             Console.WriteLine("length of 1st edge:" + x);
             Console.WriteLine("length of 2nd edge:" + y);
             Console.WriteLine("length of 3rd edge:" + z);
           
        }
        public void TestTriangle()
        {
            if(x==y&&y==z)
                Console.WriteLine("Triangle is equilateral");
            else if(x==y||y==z||z==x)
                Console.WriteLine("Triangle is isosceles");
            else
                Console.WriteLine("Triangle is scalene");

        }

    }
}