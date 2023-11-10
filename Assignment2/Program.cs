using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList studentGrades = new ArrayList() { 85, 92, 78, 95, 88 };
            Console.WriteLine("student Grades");
            
            foreach (var grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            //adding the grades
            int sum = 0;
            foreach(var grade in studentGrades)
            { 
            sum += (int)grade;
                
            }
            Console.WriteLine($"sum of all grades:{sum}");
            //adding 90  to the grades
            studentGrades.Add(90);
            Console.WriteLine("the updated grades are");
            foreach(var grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            //Removing 78 from grades
            studentGrades.Remove(78);
            Console.WriteLine("the updated grades are");
            foreach (var grade in studentGrades)
            {
                Console.WriteLine(grade);
            }
            //seaching for the index 0f 95 and upgrading it to 96
            int indexOf95 = studentGrades.IndexOf(95);

            
                // Update the grade at the found index to 96
                studentGrades[indexOf95] = 96;

                // Display the updated contents
                Console.WriteLine("\nUpdated Student Grades:");
                foreach (var grade in studentGrades)
                {
                    Console.WriteLine(grade);
                }
            
            Console.ReadKey();
        }
    }
}
