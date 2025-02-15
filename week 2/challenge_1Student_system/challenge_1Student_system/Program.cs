using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace challenge_1Student_system
{
    internal class Program
    {
        static List<student> students = new List<student>();

        static void AddStudent()
        {
            Console.Write("Enter student name: ");
            string name = Console.ReadLine();

            Console.Write("Enter matric marks : ");
            int matricMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter FSC marks : ");
            int fscMarks = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter ECAT marks: ");
            int ecatMarks = Convert.ToInt32(Console.ReadLine());

            student student = new student(name, matricMarks, fscMarks, ecatMarks);
            students.Add(student);
            Console.WriteLine("Student added successfully!\n");
        }

        static void ShowStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students added yet.\n");
            }
            else
            {
                foreach (var student in students)
                {
                    Console.WriteLine($"Name: {student.name}, Matric Marks: {student.matric}, FSC Marks: {student.inter}, ECAT Marks: {student.ecat}, Aggregate: {student.aggregate}");
                }
                Console.WriteLine();
            }
        }

        static void CalculateAggregates()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students added yet.\n");
            }
            else
            {
                foreach (var student in students)
                {
                    student.CalculateAggregate();
                }
                Console.WriteLine("Aggregates calculated successfully!\n");
            }
        }

       /* static void TopStudents()
        {
            if (students.Count == 0)
            {
                Console.WriteLine("No students added yet.\n");
            }
            else
            {
                Console.WriteLine("Top 3 Students:");
                // Sort students by aggregate in descending order
                var topStudents = students.OrderByDescending( student.CalculateAggregate).Take(3); ;
                foreach (var student in topStudents)
                {
                    Console.WriteLine($"Name: {student.Name}, Matric Marks: {student.MatricMarks}, FSC Marks: {student.FscMarks}, ECAT Marks: {student.EcatMarks}, Aggregate: {student.aggregate}");
                }
                Console.WriteLine();
            }
        }
       */
        private static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("-----Menu:----");
                Console.WriteLine("1.Add Student");
                Console.WriteLine("2.Show Students");
                Console.WriteLine("3.Calculate Aggregates");
                
                Console.WriteLine("4.Exit");
                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddStudent();
                        break;
                    case "2":
                        ShowStudents();
                        break;
                    case "3":
                        CalculateAggregates();
                        break;
                   
                        
                    case "4":
                        Console.WriteLine("Exiting program. ");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.\n");
                        break;
                }


            }

        }
    }
}

    

    

