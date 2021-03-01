using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Ridwan", "111222", 3.10f);
            Student s2 = new Student("Rijon", "333444", 3.85f);
            Student s3 = new Student("Jenia", "555666", 3.50f);


            Department d1 = new Department("Computer Science", "CS");
            Department d2 = new Department("Electrical Eng", "EEE");
            s1.Dept = d1;
            s2.Dept = d1;
            s3.Dept = d2;
            d1.AddStudent(s1, s2);
            d2.AddStudent(s3);

            s1.ShowDepartmentInfo();
            s3.ShowDepartmentInfo();
            Console.WriteLine("############");
            d1.Name = "Computer Science & Eng";
            d1.Id = "CSE";
            s1.ShowDepartmentInfo();
            d1.PrintStudents();
            s3.Name = "Jenia";
            d2.PrintStudents();
        }
    }
}
