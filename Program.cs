namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = false;
            while (!isPrime)
            {
                Console.Write("Enter a prime number to exit: ");
                string? input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("You didn't enter a number!");
                    continue;
                }

                int number;

                try
                {
                    number = int.Parse(input);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You didn't enter a number!");
                    continue;
                }

                if (!IsPrime(number))
                {
                    Console.WriteLine("You didn't enter a prime number!");
                    continue;
                }
                else
                {
                    Console.WriteLine("You entered a prime number!");
                    break;
                }
            }
        }

        static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
