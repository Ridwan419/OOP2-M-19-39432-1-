using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Practise
{
    class Program
    {
        static void Main(string[] args)
        {
            Student obj1 = new Student("Ridwan", "39432", "CSE", 3.11f);
            obj1.showInfo();
            Triangle obj2 = new Triangle(10, 20, 10);
            obj2.ShowInfo();
            obj2.TestTriangle();
            Course obj3 = new Course("OOP2", "345432", 3);
            obj3.ShowInfo1();
            Account obj4 = new Account("Ridwan", "6565", 400);
            obj4.Deposit(400);
            obj4.Withdraw(400);
            
        }
    }
}