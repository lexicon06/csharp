using System;
using System.Collections.Generic;

/* TODO 
- Add array to store used wrong letters to avoid losing more points.
- Add a better error handling.
- Add new game option and switch the word ofc.
*/

namespace Hangman
{
    class Program
    {
        static readonly string[] words = { "jugar", "correr", "cantar", "programar", "ladrar", "caminar" };
        static string word = string.Empty;

        
        static readonly string[] hangmanImage = {  
            "  +---+\n" +
            "  |   |\n" +
            "      |\n" +
            "      |\n" +
            "      |\n" +
            "      |\n",
            "  +---+\n" +
            "  |   |\n" +
            "  O   |\n" +
            "      |\n" +
            "      |\n" +
            "      |\n",
            "  +---+\n" +
            "  |   |\n" +
            "  O   |\n" +
            "  |   |\n" +
            "      |\n" +
            "      |\n",
            "  +---+\n" +
            "  |   |\n" +
            "  O   |\n" +
            " /|   |\n" +
            "      |\n" +
            "      |\n",
            "  +---+\n" +
            "  |   |\n" +
            "  O   |\n" +
            " /|\\  |\n" +
            "      |\n" +
            "      |\n",
            "  +---+\n" +
            "  |   |\n" +
            "  O   |\n" +
            " /|\\  |\n" +
            " /    |\n" +
            "      |\n",
            "  +---+\n" +
            "  |   |\n" +
            "  O   |\n" +
            " /|\\  |\n" +
            " / \\  |\n" +
            "      |\n"
        };


        static Random random = new Random();
        static int numero;
        static string palabra = "";
        static List<char> characters = new List<char>();
        static List<char> collection = new List<char>();

        static string Author = "Pablo Ignacio Santillan";
        const int maxWrong = 6;

        static int wrong;


        private static void SelectWord(){
            numero = random.Next(0, words.Length);
            palabra = words[numero].ToUpper();

        }

        private static void Play(){

            foreach (char t in palabra)
            {
                characters.Add(t);
            }

            for (int i = 0; i < characters.Count; i++)
            {
                word += "_ ";
            }

           Console.WriteLine($"💡 {word}💡");

            while (word.Contains("_"))
            {
                Console.WriteLine("Type a letter to guess the word");
                string input = Console.ReadLine() ?? "";

                char c = char.ToUpper(Convert.ToChar(input[0]));

                if(wrong == maxWrong){
                    Console.WriteLine(hangmanImage[wrong]);
                    Console.WriteLine($"Already dead {Author}, Sorry mate! Game Over");
                    break;
                }

                if(!characters.Contains(c)){
                    Console.WriteLine(hangmanImage[wrong]);
                    Console.WriteLine($"You've made a mistake {Author}!, you have {maxWrong - wrong} tries left");
                    wrong++;
                    
                }

                if (char.IsLetter(c))
                {

                    word = string.Empty;

                    for (int i = 0; i < characters.Count; i++)
                    {
                        if (c == characters[i])
                        {
                            if (!collection.Contains(c))
                            {
                                collection.Add(c);
                            }
                            word += c + " ";//i could avoid this and add a string builder but since it's just lil word won't matter
                        }
                        else if(collection.Contains(characters[i]))
                        {
                            word += characters[i] + " ";
                        }
                        else
                        {
                            word += "_ ";
                        }
                    }

                   Console.WriteLine($"💡 {word}💡");

                   if(!word.Contains("_")){
                    Console.WriteLine($"🎉 Gratz, you won {Author}!!! 🥳🎉");
                   }
                }
                else
                {
                    Console.WriteLine($"Please enter a valid letter");
                }
            }
        }

        public static void Main(string[] args)
        {
            SelectWord();
            Play();
        }
    }
}
