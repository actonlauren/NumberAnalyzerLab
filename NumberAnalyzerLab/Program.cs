namespace NumberAnalyzerLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool keepGoing = true;
            int userNumber;
            Console.WriteLine("Hello please provide your name to continue.");
            string usersName = Console.ReadLine();
            do 
            {
                Console.WriteLine($"Thank you {usersName}. Please enter a number between 1 and 100");
                string userInput = Console.ReadLine();
                if (int.TryParse(userInput, out userNumber))
                {
                    
                    if (userNumber % 2 == 0)
                    {
                        if (userNumber >= 2 && userNumber <= 24)
                        {
                            Console.WriteLine("Even and less than 25.");
                        }
                        if (userNumber >= 26 && userNumber <= 60)
                        {
                            Console.WriteLine("Even and between 26 and 60 inclusive.");
                        }
                        if (userNumber > 60)
                        {
                            Console.WriteLine("Even and greater than 60.");
                        }
                    }
                    if (userNumber % 2 != 0)
                    {
                        if (userNumber < 60)
                        {
                            Console.WriteLine("Odd less than 60.");
                        }
                        if (userNumber > 60)
                        {
                            Console.WriteLine("Odd greater than 60.");
                        }
                    }
                }

                Console.Write($"{usersName} Would you like to continue? T/F :");
                string userContinue = Console.ReadLine();
                if (userContinue == "F" || userContinue == "f")
                {
                    keepGoing = false;
                }

            } while (keepGoing && userNumber >= 1 && userNumber <= 100);

            Console.WriteLine($"Thanks for playing {usersName}");
        }
    }
}