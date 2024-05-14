
namespace CrocodileGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Crocodile Game!");
            Console.WriteLine("");
            while (true)
            {

                Random FirstNumber = new Random();
                var Number1 = FirstNumber.Next(0, 11);
                Random SecondNumber = new Random();
                var Number2 = SecondNumber.Next(0, 11);

                
                Console.WriteLine("Write your Answer using: < = >, use x to Exit");
                Console.WriteLine("");
                Console.Write(Number1 + " _ " + Number2);
                Console.WriteLine("");
                string Answer = Console.ReadLine();
                if (Answer == "x") break;
                if (Answer == "=")
                {
                    if (Number1 == Number2)
                        Console.WriteLine("Correct");
                    else Console.WriteLine("Wroooong");
                    Console.WriteLine("");
                }
                else if (Answer == ">")
                {
                    if (Number1 > Number2) 
                        Console.WriteLine("Correct");
                    else Console.WriteLine("Wroong");
                    Console.WriteLine("");
                }
                else if (Answer == "<")
                {
                    if (Number1 < Number2) 
                        Console.WriteLine("Correct");
                    else Console.WriteLine("Wroooong!!!!");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("What the hell? That's not even the right symbols!");
                    Console.WriteLine("");
                }

            
            }

        }
    }
}
