using System;

namespace helloworld
{
    class MainClass
    {

        static void Main(string[] args)
        {
            int studentScoreTotal = 0;
            int numberOfStudents = 0;
            string studentScore;
            int result;

            Console.WriteLine("What teacher is using this program today?");
            string teacherName = Console.ReadLine();

            do
            {
                Console.WriteLine("Please enter the student's score.");
                studentScore = Console.ReadLine();

                if (int.TryParse(studentScore, out result))
                {
                    if (result >= 0 && result < 21)
                    {
                        studentScoreTotal += result;
                        numberOfStudents++;
                    }
                    else 
                    {
                        Console.WriteLine("Improper test score...please try again");
                        continue;
                    }
                }
                else 
                {
                    Console.WriteLine("Please enter a real number...");
                    continue;
                }
                Console.WriteLine(result);

            }
            while (result != -1);
            double classAverage = Convert.ToDouble(studentScoreTotal) / Convert.ToDouble(numberOfStudents);
            Console.WriteLine("Averaging student test scores for {0}'s class of {1} student(s).", teacherName, numberOfStudents);
            Console.WriteLine("Class average is: {0}", classAverage);
        }
    }
}














