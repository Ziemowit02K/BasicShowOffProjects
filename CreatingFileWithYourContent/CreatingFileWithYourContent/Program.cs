using System;
using System.IO;
using System.Text;

class fileexercie
{
    public static void Main()
    {
        
        try
        {
            Welcoming();
            Introduction();

            //Creating name of file by user
            string fileNameusers = string.Empty;
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.Write("              Input name of the file: ");
            fileNameusers = Console.ReadLine();

            Console.Clear();

           

            //Cheking the name of file
            if (IsItString(fileNameusers))
            {

                Console.Write("Input your name:");
                string userAuthor = Console.ReadLine();

                string fileNameUsers = fileNameusers.ToString();

                //creating file
                string FileName = @"" + fileNameUsers + ".txt";
                //checking if file exist
                if (File.Exists(FileName))
                {
                    File.Delete(FileName);
                }

                //Taking title from user
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.Write("Input title of the note: ");
                string userTitle = Console.ReadLine();
                if (IsItString(userAuthor))
                {
                    Console.Clear();

                    //Taking Content from user
                    //Console.WriteLine("----------------------------------------------------------------------------");
                    //Console.Write("Input content of the file: ");
                    //string userContent = Console.ReadLine();
                    //Console.Clear();
                    //Instruction about how this part of programm works
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("            Now we are going to take some content from you :) ");
                    Console.WriteLine("All you need to do is give us the number of lines and then write them down");
                    Console.WriteLine("         When you are ready to move to next line just click enter ");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("                         Press enter to continue");
                    Console.ReadKey();
                    Console.Clear();


                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.Write("             Input number of lines to cut the contnent in the file: ");
                    int number = Convert.ToInt32(Console.ReadLine());

                    string[] ContentLines = new string[number];


                    CreatingTab(ContentLines, number);


                    if (IsItString(userTitle))
                    {

                        WritingToFile(FileName, ContentLines, userTitle, userAuthor);

                        ReadingFromFile(FileName, userTitle);
                    }
                    else
                    {

                        ElseInstruction();
                    }
                }
                else
                {
                    ElseInstruction();
                }
               

            }
            else
            {
                ElseInstruction();
            }

            
        }
        catch (Exception MyExcep)
        {
            Console.WriteLine(MyExcep.ToString());
        }
    }
    public static void Welcoming() //  welcoming method made to make code easier to read
    {
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("                  Hello!                    ");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("         Press ENTER to continue                              ");
        Console.ReadKey();
        Console.Clear();
    }
    public static bool IsItString(string str) //IsItString or IsItNumber method created to foresse users decison
    {
        if(int.TryParse(str,out int i))
        {
            return false;
        }
        return true;
    }
    public static void WritingToFile(string FileName, string[] tab, string title, string author)
    {
        using (System.IO.StreamWriter fileContent = new System.IO.StreamWriter(@FileName))
        {
            fileContent.WriteLine(title);
            foreach (string line in tab)
            {
                fileContent.WriteLine(line);
            }
            fileContent.WriteLine();
            fileContent.WriteLine("Title: {0} by {1}", title, author);
        }

    }
    public static void ReadingFromFile(string FileName, string title)
    {
        using (StreamReader fileRead = File.OpenText(@FileName))
        {
            string s = "";
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("                              " + title + "                                             ");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.WriteLine();
            while ((s = fileRead.ReadLine()) != null)
            {
                Console.WriteLine("          {0}     ", s);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
    public static void CreatingTab(string[] tab, int n)
    {

        //Creating a tab

        Console.Clear();
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("                        Time for some content");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine();
        for (int i = 0; i < n; i++)
        {
            Console.Write("Input line {0}: ", i + 1);
            tab[i] = Console.ReadLine().ToString();
        }
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("Press Enter to continue");
        Console.ReadKey();
        Console.Clear();
        
    }
    public static void Introduction()
    {
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("      Im gonna help you to write some in file we will create for you");
        Console.WriteLine("                Give us a second, we will check if file exist");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("                         Press ENTER to continue");
        Console.ReadKey();
        Console.Clear();
    }
    public static void ElseInstruction()
    {
        Console.Clear();
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("                     Please keep it not a number");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("                         Do you want to try again?");
        Console.Write("                                 Type yes or no: ");
        string result = Console.ReadLine();
        Console.WriteLine("----------------------------------------------------------------------------");

        if (IsItString(result))
        {
            result.ToString();
            
            if (result == "yes" || result == "Yes" || result == "YES" || result == "y" || result == "Y")
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("                         Press ENTER to continue");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("                                 Goodbye!");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("                         Press ENTER to continue");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Console.ReadKey();
            }
        }
    }

}
