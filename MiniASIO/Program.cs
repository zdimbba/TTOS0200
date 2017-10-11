using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniASIO
{
    class TestStudent
    {
        static void Teststudent()
        {
            //Create a list.
            List<Student> students = new List<Student>();
            //Different ways to add objects to list.
            Student aku = new Student("Aku", "Naku");
            students.Add(aku);
            students.Add(new Student("Antti", "Lantti", "A1234"));
            //Also:
            students.Add(new Student { Firstname = "Toni", Lastname = "Poni", AsioID = "B5678" });
            students.Add(new Student { Firstname = "Lasse", Lastname = "Mortensen", AsioID = "C9000", Group = "TTV03S3" });
            Student kalle = new Student();
            kalle.Firstname = "Kalle"; kalle.Lastname = "Kuikkaa"; kalle.AsioID = "D2347"; kalle.Group = "EiIkinä";
            students.Add(kalle);
            //Print out one student.
            Console.WriteLine("Give a number between 1-{0} ", students.Count);
            int givenNumber = int.Parse(Console.ReadLine());
            if (givenNumber-1 < students.Count)
                Console.WriteLine("MiniASIO {0} student is number {1}", givenNumber, students[givenNumber - 1].ToString());
            else
                Console.WriteLine("MiniASIO has only {0} entries.", students.Count);
            //Every entry printed
            Console.WriteLine("\nMiniASIO all entries:");
            foreach (var complete in students)
            {
                Console.WriteLine(complete.ToString());
            }
            //All entries alphabetical order (Lastname)
            //Sort objects by Lastname
            students.Sort((x, y) => x.Lastname.CompareTo(y.Lastname));
            Console.WriteLine("\nMiniASIO all entries sorted by Lastname:");
            foreach (var complete in students)
            {
                Console.WriteLine(complete.ToString());
            }
            //Add new student, check if ID is taken.
            Console.WriteLine("\nGive new AsioID: ");
            string asioid = Console.ReadLine();
            bool flag = false;
            foreach (Student complete in students)
            {
                if (asioid == complete.AsioID)
                {
                    flag = true;
                    break;
                }
            }
            if (flag)
            {
                Console.WriteLine("AsioID {0} is taken.", asioid);
            }
            else
            {
                Console.WriteLine("\nGive new first name: ");
                string firstname = Console.ReadLine();
                Console.WriteLine("\nGive new last name: ");
                string lastname = Console.ReadLine();
                Console.WriteLine("\nGive new group: ");
                string group = Console.ReadLine();

                Student rookie = new Student(firstname, lastname, asioid, group);
                students.Add(rookie);
                Console.WriteLine("\nMiniASIO all {0} entries:", students.Count);
                foreach (var complete in students)
                {
                    Console.WriteLine(complete.ToString());
                }
            }
        }
        static void Main(string[] args)
        {
            Teststudent();
        }
    }
}
