

namespace HelloWorld
{
    public class FlipCoin
    {
        public static void CalculatePercentage()
        {

            Console.WriteLine("Please enter the value for number of flips");
            //int head = 0;
            //int tail = 0;
            int headcount = 0;
            int tailcount = 0;

            double headpercentage;
            double tailpercentage;

            int flipCoin = Convert.ToInt32(Console.ReadLine());
            if (flipCoin > 0)
            {
                for (int i = 0; i < flipCoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("The random number generated is " + number);
                    if (number == 0)
                    {
                        Console.WriteLine("tail");
                        tailcount++;
                    }
                    else
                    {
                        Console.WriteLine("head");
                        headcount++;
                    }
                }
                Console.WriteLine("the tail count is " + tailcount);
                Console.WriteLine("the head count is " + headcount);
                headpercentage = headcount * 100 / flipCoin;
                tailpercentage= tailcount * 100 / flipCoin;
                Console.WriteLine("headpercentage  " + headpercentage);
                Console.WriteLine("tailpercentage  " + tailpercentage);
            }
            else
            {
                Console.WriteLine("Print enter a valid number");
            }
        }
    }
}


    
