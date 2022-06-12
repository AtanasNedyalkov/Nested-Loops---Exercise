using System;

namespace _06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int studentSum = 0;
            int standardSum = 0;
            int kidSum = 0;
            int ticketsCount = 0;

            while (input != "Finish")
            {
                int freePlaces = int.Parse(Console.ReadLine());
                double human = 0;

                for (int i = 0; i < freePlaces; i++)

                {
                    string typeOfTicket = Console.ReadLine();
                    if (typeOfTicket == "End")
                    {

                        break;
                    }
                    else if (typeOfTicket == "student")
                    {
                        studentSum++;

                    }
                    else if (typeOfTicket == "standard")
                    {
                        standardSum++;


                    }
                    else if (typeOfTicket == "kid")
                    {
                        kidSum++;

                    }
                    human++;
                    ticketsCount++;
                }
                Console.WriteLine($"{input} - {(human * 100) / freePlaces:F2}% full.");
                input = Console.ReadLine();
            }
            double totalticketsSum = standardSum + studentSum + kidSum;
            Console.WriteLine($"Total tickets: {ticketsCount}");
            Console.WriteLine($"{(studentSum*100/totalticketsSum):f2}% student tickets.");
            Console.WriteLine($"{(standardSum*100)/ totalticketsSum :f2}% standard tickets.");
            Console.WriteLine($"{(kidSum*100)/ totalticketsSum :f2}% kids tickets.");




        }
    }
}
