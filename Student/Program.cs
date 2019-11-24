using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Program
    {
        static void Main (string[] args)
        {
            using (StudentContext db = new StudentContext())
            {
                //Додавання даних в Базу Даних 
                Console.WriteLine("Введіть ім'я студента");
                Console.WriteLine("Щоб закінчити, введіть end");
                string name = Console.ReadLine();
                while (name != "end")
                {
                    Student student = new Student { Name = name };
                    db.Students.Add(student);
                    db.SaveChanges();
                    name = Console.ReadLine();
                }
                Console.WriteLine("Список успішно збережений!");


                var students = db.Students;
                Console.WriteLine("Список студентів:");
                foreach (Student u in students)
                {
                    Console.WriteLine("{0}.{1}", u.Id, u.Name);
                }
            }
            Console.ReadKey();
        }
    }
}
