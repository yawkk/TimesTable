namespace TimesTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Times Table");
            try
            {
                
                byte? number = 0;
                Console.WriteLine("Enter a number to check see the times table");
                number =byte.Parse(Console.ReadLine());  // Ask the user to enter a valid number and it parse the number from string to byte
                int? row;
                for (row = 1; row <= 12; row++)  // we will iterate the number to a maximum of 12.
                {
                    Console.WriteLine($"{number} *{row} = {row * number}");
                }
            }catch (OverflowException)
            {
                Console.WriteLine("too much number to calculate");
            }catch (Exception e)
            {
                Console.WriteLine("Enter a valid number");
            }

            


        }
    }
}