using System;
namespace exercises
{
    struct book
    {
        public string title;
        public string autor;
        public int id;
    }
    public class strucExercises
    {
        public static void Main()
        {
            int count = 0;
            Welcoming();
            Console.Write("Insert number of books you want to add: ");
            string NumberGiven = Console.ReadLine();
            Console.WriteLine("Press enter to continue");
            Console.Clear();
            if (IsItNumber(NumberGiven))
            {
                int number = Convert.ToInt32(NumberGiven);
                book[] books = new book[number];
                
                for(int i = 0; i < number; i++)
                {
                    Console.Clear();
                    Console.WriteLine("             Information of book numer {0}.",i+1);

                    Console.WriteLine("");
                    Console.Write("Input title of the book: ");
                    books[i].title = Console.ReadLine();
                    //if ((IsItNumber(books[i].title) == false) || books[i].title!=null)
                    //{
                        Console.Write("Input author: ");
                        books[i].autor = Console.ReadLine();
                        //if((IsItNumber(books[i].title) == false) || books[i].autor != null)
                        //{
                            books[i].id = i + 1;
                        //}
                        //else
                        //{
                        //    ElseInstruction();
                            
                        //}
                    //}
                    //else
                    //{
                    //    ElseInstruction();
                    //}
                }
                
                for(int i = 0; i <number; i++)
                {
                    if (((IsItNumber(books[i].title)) == true) || ((IsItNumber(books[i].autor) == true)))
                    {
                        books[i].title = "ERROR, wrong input";
                        books[i].autor = "ERROR, wrong input";
                    }
                    else
                    {
                        count++;
                    }
                }
                Console.Clear() ;
                for(int i = 0; i < number; i++)
                {
                    
                    Console.WriteLine();
                    Console.WriteLine("Book number:  {0} ",i+1);
                    Console.WriteLine("Title:       {0} ", books[i].title);
                    Console.WriteLine("Author:      {0}", books[i].autor);
                    Console.WriteLine();
                }
                Console.WriteLine("");
                Console.WriteLine("Correct elements: {0}",count);
                Console.WriteLine("Uncorrect elements: {0}",number-count);
                Console.WriteLine("That was all of it");
                Console.WriteLine("Press ENTER to leave");
                Console.ReadKey();

            }
            else
            {
                ElseInstruction();
            }
        }
        public static bool IsItNumber(string str)
        {
            if(int.TryParse(str, out int result))
            {
                return true;
            }
            else
            {
                return false;
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
        public static void ElseInstruction()
        {
            Console.WriteLine("Somthing came wrong");
            Console.WriteLine("Sorry that I need to ask but would you try again? ");
            Console.Write("Do you wanna restart? (Yes/No): ");
            string resultGiven = Console.ReadLine();
            Console.WriteLine("Press ENTER to continue");
            Console.ReadKey();
            
            if (!(IsItNumber(resultGiven)))
            {
                resultGiven.ToLower();
                if (resultGiven == "yes")
                {
                    Console.Clear();
                    Main();
                }
                else if(resultGiven == "no")
                {
                    Console.Clear();
                    Console.WriteLine("Press enter to leave");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Something came wrong ... again: ");
                    Console.ReadKey();
                    Console.WriteLine("I am out, enought...");
                    Console.WriteLine("Press ENTER to leave");
                    Console.ReadKey();

                }
            }


        }


    }

}
