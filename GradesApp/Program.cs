/*Programmer: Mhd Nidal Alafandi
 * Date: 08/30/2022
 * Subject: Devliverable 2
 */

namespace GradesApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the grade value: ");            

            try
            {
                int grade = Convert.ToInt32(Console.ReadLine());
                

                if ((grade >= 98) && (grade <= 100))
                {
                    Console.WriteLine("Your letter grade is " + "A+");
                }
                else if ((grade >= 92) && (grade <= 97))
                {
                    Console.WriteLine("Your letter grade is " + "A");
                }
                else if ((grade >= 90) && (grade <= 91))
                {
                    Console.WriteLine("Your letter grade is " + "A-");
                }
                else if ((grade >= 88) && (grade <= 89))
                {
                    Console.WriteLine("Your letter grade is " + "B+");
                }
                else if ((grade >= 82) && (grade <= 87))
                {
                    Console.WriteLine("Your letter grade is " + "B");
                }
                else if ((grade >= 80) && (grade <= 81))
                {
                    Console.WriteLine("Your letter grade is " + "B-");
                }
                else if ((grade >= 78) && (grade <= 79))
                {
                    Console.WriteLine("Your letter grade is " + "C+");
                }
                else if ((grade >= 72) && (grade <= 77))
                {
                    Console.WriteLine("Your letter grade is " + "C");
                }
                else if ((grade >= 70) && (grade <= 71))
                {
                    Console.WriteLine("Your letter grade is " + "C-");
                }
                else if ((grade >= 68) && (grade <= 69))
                {
                    Console.WriteLine("Your letter grade is " + "D+");
                }
                else if ((grade >= 62) && (grade <= 67))
                {
                    Console.WriteLine("Your letter grade is " + "D");
                }
                else if ((grade >= 60) && (grade <= 61))
                {
                    Console.WriteLine("Your letter grade is " + "D-");
                }
                else if ((grade < 60))
                {
                    Console.WriteLine("Your letter grade is " + "F");
                }
                else
                {
                    Console.WriteLine("Value must be an integer under 100! ");
                }
            }
            catch
            {
                Console.WriteLine("Input must be an integer value only!");
            }
        }
    }
}