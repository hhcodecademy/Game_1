namespace Game_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random= new Random();
            int randomNumber=random.Next(1, 100);
            int attempts = 0;

            while (true)
            {
                attempts++;
                Console.WriteLine("Please enter your guess number(1-100):");
                int myNumber=int.Parse(Console.ReadLine());

                if (myNumber == randomNumber)
                {
                    Console.WriteLine("Congrats! You win!");
                    Console.WriteLine($"Your attempt count: {attempts}");
                    break;
                }
                else if( myNumber< randomNumber )
                {
                    Console.WriteLine("Your guess is too low");
                }
                else
                {
                    Console.WriteLine("Your guess is too high");
                }
            }
        }
    }
}