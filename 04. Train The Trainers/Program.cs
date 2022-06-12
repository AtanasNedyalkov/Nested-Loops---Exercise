using System;

namespace _04._Train_The_Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string presentation = Console.ReadLine();
            int students = 0;
            double evaluations = 0;
            double personalEvaluation = 0;
            
            while (presentation!= "Finish")
            {
                personalEvaluation = 0;

                for (int i = 1; i <= n; i++)
                {
                    personalEvaluation += double.Parse(Console.ReadLine());
                }
                personalEvaluation = personalEvaluation / n;
                Console.WriteLine($"{presentation} - {personalEvaluation:F2}.");
                students++;
                evaluations += personalEvaluation;

                presentation = Console.ReadLine();
            }
            evaluations = evaluations / students;
            Console.WriteLine($"Student's final assessment is {evaluations:F2}.");
        }
    }
}
