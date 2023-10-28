using System;

namespace Main
{
    class Program
    {
        public static void Main(string[] args)
        {
            var rnd = new Random();

            int number = rnd.Next(1, 100);

            Console.WriteLine("Guess a number between 1 and 100");

            string input = Console.ReadLine() ?? "";
            int guess = 0;

            if(input == ""){
                Console.WriteLine("Please enter a valid input");
                return;
            }

            for(var i=0;i<input.Length;i++){
                if(char.IsLetter(input[i])){
                    Console.WriteLine("Your input is wrong, please enter a valid input");
                    return;
                }
            }

            guess = Convert.ToInt32(input);

            if(guess<1 || guess>100){
                Console.WriteLine("Your input is wrong, please enter a valid input between 1 and 100");
                return;
            }else if(guess == number){
            Console.WriteLine($"Bingo! you did amazing bravo, the number was {number}");
            }else{
            Console.WriteLine($"Sorry but {guess} was wrong, the number was {number}");
            }
        }
    }
}