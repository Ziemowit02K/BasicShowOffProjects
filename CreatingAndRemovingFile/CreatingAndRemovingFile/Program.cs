using System;
using System.IO;
using System.Text;

class fileexercie
{
    public static void Main()
    {
        string fileName = @"test.txt";
        Welcoming();
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("            Im gonna help you remove file test.txt from the disk");
        Console.WriteLine("                Give us a second, we will check if file exist");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("                         Press ENTER to continue");
        Console.ReadKey();
        Console.Clear();
        if (File.Exists(fileName))
        {
            Console.Clear();
            File.Delete(fileName);
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("    The file {0} deleted successfully ",fileName);
            Console.WriteLine("------------------------------------------");
        }
        else
        {
            FileDoesNotExist(fileName);
        }
    }
    public static void Welcoming()
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("                  Hello!                    ");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("         Press ENTER to continue                              ");
        Console.ReadKey();
        Console.Clear();
    }
    public static void FileDoesNotExist(string fileName)
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("            File does not exist");
        Console.WriteLine("         Do you want to create a file?");
        Console.WriteLine("              Type Yes or NO");
        Console.WriteLine("------------------------------------------");
        Console.Write("                Input here: ");
        string result = (Console.ReadLine()).ToString();
        result.ToLower();
        if (result == "yes")
        {
            using (FileStream fileStr = File.Create(fileName))
            {
                Console.Clear();
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("    A file created with name test.txt");
                Console.WriteLine("      Press ENTER to restart program");
                Console.WriteLine("------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("    Are you sure? Program will shut down               " );
            Console.WriteLine("              Type Yes or NO");
            Console.WriteLine("------------------------------------------");
            Console.Write("                Input here: ");
            string result1 = (Console.ReadLine()).ToString();
            result.ToLower();
            if (result1 == "yes")
            {
                Console.WriteLine("------------------------------------------");
                Console.WriteLine("                 Goodbye");
                Console.WriteLine("------------------------------------------");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                using (FileStream fileStr = File.Create(fileName))
                {
                    Console.WriteLine("A file created with name test.txt");
                    Console.WriteLine("Press ENTER to restart program");
                    Console.ReadKey();
                    Console.Clear();
                    Main();
                }

            }
        }
    }

}