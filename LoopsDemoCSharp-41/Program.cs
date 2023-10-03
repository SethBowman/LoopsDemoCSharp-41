namespace LoopsDemoCSharp_41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //While
            Console.WriteLine("WHILE LOOP:");

            var cont = "yes";

            while(cont == "yes")
            {
                Console.WriteLine("Continue? Type \"yes\" or \"no\"");
                cont = Console.ReadLine();
            }

            Console.WriteLine("Press enter.");
            Console.ReadKey();

            //Do while
            Console.WriteLine("DO WHILE LOOP");

            var num = 6;

            do
            {
                Console.WriteLine(num);
                num++;
            } while(num <= 5);

            Console.WriteLine("Press enter.");
            Console.ReadKey();

            //For loop
            Console.WriteLine("FOR LOOP:");

            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} is the number we are on");
            //}

            for(int i = 10; i >= 1; i--)
            {
                Console.WriteLine($"{i} is the number we are on");
            }

            Console.WriteLine("Press enter.");
            Console.ReadKey();

            //Foreach loop
            Console.WriteLine("FOREACH LOOP:");
            var numbers = new int[] { 23, 3, 444, 500, 12};

            foreach(int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}