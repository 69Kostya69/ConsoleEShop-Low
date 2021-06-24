using System;

namespace EShop
{

    static class UI
    {
        public static void LaunchMenu()
        {
            while (true)
            {
                Console.WriteLine("Hello Anonymous!\n" +
                                  "Select an action:\n" +
                                  "1) View the list of products;\n" +
                                  "2) LogIn;\n" +
                                  "3) Regestration;\n" +
                                  "4) Exit\n" +
                                  "Your choose: ");
                try
                {
                    int n = int.Parse(Console.ReadLine());

                    switch (n)
                    {
                        case 1:
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            Console.WriteLine("Goodbye!");
                            return;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error input! Try again\n");
                            Console.ResetColor();
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{ex.Message}\n");
                    Console.ResetColor();
                }
                
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            UI.LaunchMenu();
        }
    }
}
