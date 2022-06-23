//  Write a program in C# Sharp to create a user define function with parameters.
using System;
namespace exercises
{
    class Program
    {
        static void Main()
        {
            Welcome();
            Console.WriteLine();
            Console.Write("Please input your name: ");
            string Name = Console.ReadLine().ToString();
            if (IsItString(Name) && Name !=string.Empty)
            {
                Console.WriteLine();
                Console.Write("Please input your last name: ");
                string LastName = Console.ReadLine().ToString();
                if (IsItString(LastName) && LastName != string.Empty)
                {
                    Console.WriteLine();
                        Console.Write("Please input your age (number):");
                    string AgeGiven = Console.ReadLine().ToString();
                    if (!(IsItString(AgeGiven)) && AgeGiven != string.Empty)
                    {
                        int Age = Convert.ToInt32(AgeGiven);
                        Console.WriteLine();
                        Console.Write("Input your Moms age (number): ");
                        string AgeOfMom = Console.ReadLine().ToString();
                        if (!(IsItString(AgeOfMom)) && AgeOfMom != string.Empty)
                        {
                            int momAge = Convert.ToInt32(AgeOfMom);
                            Console.WriteLine();
                            Console.Write("Input your Dads age (number): ");
                            string AgeOfDad = Console.ReadLine().ToString();
                            if (!(IsItString(AgeOfDad)) && AgeOfDad != string.Empty)
                            {
                                int dadAge = Convert.ToInt32(AgeOfDad);
                                Console.WriteLine();
                                Console.Write("Insert your profession: ");
                                string profession = Console.ReadLine().ToString();
                                if (IsItString(profession) && profession != string.Empty)
                                {
                                    Console.WriteLine();
                                    Console.Write("Insert where are you from: ");
                                    string wohen = Console.ReadLine().ToString();
                                    if (IsItString(wohen) && wohen != string.Empty)
                                    {
                                        EndingCard(Name, LastName, Age, profession, wohen, momAge, dadAge);

                                    }
                                    else
                                    {
                                        ExpressionBeforeDecision();
                                        string answer = (Console.ReadLine()).ToString();
                                        RestartingDecision(answer);
                                    }

                                }
                                else
                                {
                                    ExpressionBeforeDecision();
                                    string answer = (Console.ReadLine()).ToString();
                                    RestartingDecision(answer);
                                }

                            }
                            else
                            {
                                ExpressionBeforeDecision();
                                string answer = (Console.ReadLine()).ToString();
                                RestartingDecision(answer);
                            }
                        }
                        else
                        {
                            ExpressionBeforeDecision();
                            string answer = (Console.ReadLine()).ToString();
                            RestartingDecision(answer);
                        }
                    }
                    else
                    {
                        ExpressionBeforeDecision();
                        string answer = (Console.ReadLine()).ToString();
                        RestartingDecision(answer);
                    }
                }
                else
                {
                    ExpressionBeforeDecision();
                    string answer = (Console.ReadLine()).ToString();
                    RestartingDecision(answer);
                }
            }
            else
            {
                ExpressionBeforeDecision();
                string answer = (Console.ReadLine()).ToString();
                RestartingDecision(answer);
            }
        }

        public static void Welcome()
        {
            Console.WriteLine("                     --- --- --- Hello! --- --- ---");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("        Today I am gonna display you your data and make you a card");
            Console.WriteLine();
            Console.WriteLine("               -- -- -- Press any key to contionue -- -- --   ");
            Console.ReadKey();
            Console.Clear();

        }
        public static bool IsItString(string str)
        {
            if(int.TryParse(str, out int i))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public static void ExpressionBeforeDecision()
        {
            Console.Clear();
            Console.WriteLine("That is impossible, something came wrong");
            Console.WriteLine("I think, you did not insert a string or it is empty");
            Console.Write("Click enter to leave OR...");
            Console.Write("Do you want to try again ? ");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Type yes or no: ");
        }
        public static void RestartingDecision(string str)
        {
            if (str == string.Empty || IsItString(str) == false)
            {
                Console.Clear();
                Console.WriteLine("Alright, goodbye then");
            }
            else
            {
                str.ToLower();
                if (str.Equals("no"))
                {
                    Console.Clear();
                    Console.WriteLine("Alright, goodbye then");
                }
                if (str.Equals("yes"))
                {
                    Console.Clear();
                    Main();
                }
            }
        }
        public static void EndingCard(string name, string lastName, int myAge ,string profession, string living,int momAge, int dadAge)
        {
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---         ");
            Console.WriteLine("                           Welcome! My name is {0} {1}, I am  {2} {3} from {4}                              ", name, lastName, myAge, profession, living);
            Console.WriteLine("My Mom's age is {0} and she had me when she was {1} years old, my Dad is {2} and when I came to world he was {3}",momAge,momAge-myAge,dadAge,dadAge-myAge);
            Console.WriteLine("                         And I love maker of this program and his code, could we hire him?                                                                                        ");
            Console.WriteLine("");
            Console.WriteLine("                                             Ain't joking                                                                                            ");
            Console.WriteLine("                --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- --- ---         ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine("Wanna start again?");
            Console.Write("Input yes or no: ");
            string answer = (Console.ReadLine()).ToString();
            RestartingDecision(answer);
        }
    }
}
