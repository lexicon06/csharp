using System;
using Steam;

namespace SteamConverterMain
{
    class MainProgram
    {
        static int? option = null;
        static string? input = "";
        public static void Main(string[] args)
        {
            while(option == null)
            {
                Console.WriteLine("");
                Console.WriteLine("Please select Which type would you like to convert");
                Console.WriteLine("1. Steam ID 64 to Steam ID 32");
                Console.WriteLine("2. Steam ID 32 to Steam ID 64");
                Console.WriteLine("3. Exit");
                Console.WriteLine("");
                
                input = Console.ReadLine();

                if(!string.IsNullOrEmpty(input) && input.Length == 1 && char.IsDigit(input[0]))
                {
                    Console.WriteLine("OK");

                    option = int.Parse(input);

                    switch(option)
                    {
                        case 1:
                        {
                            Console.WriteLine("Converting to steam id 32");
                            Console.WriteLine("Please Enter a steamID64");
                            input = Console.ReadLine();
                            
                            if(!string.IsNullOrEmpty(input))
                            {
                                Console.WriteLine(SteamIdConverter.ConvertToSteamId(long.Parse(input)));
                            }
                            break;
                        }
                        case 2:
                        {
                            Console.WriteLine("Converting to steam id 64");
                            Console.WriteLine("Please Enter a SteamID 32");
                            input = Console.ReadLine();
                            
                            if(!string.IsNullOrEmpty(input))
                            {
                                long steamId64 = SteamIdConverter.ConvertToSteamId64(input);
                                Console.WriteLine($"https://steamcommunity.com/profiles/{steamId64}");
                            }
                            break;
                        }
                        case 3:
                        {
                            return;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Please enter a valid value between 1 & 3");
                }
            }
        }
    }
}
