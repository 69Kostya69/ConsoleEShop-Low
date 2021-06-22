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
                int n = int.Parse(Console.ReadLine());
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
