using System;

public class Students
{
    public int Id;
    public string Name;
    public string SurName;
    public string Grade;
    public string Result;

    public Students(int id, string name, string surName, string grade, string result)
    {
        Id = id;
        Name = name;
        SurName = surName;
        Grade = grade;
        Result = result;
    }
}
public class Objectexercises
{
    
    public static void Main()
    {
        //Declaring variables
        int typeOfError;
        string result, name, NumberGiven, nameOfFile, surName, grade;



        //Saying "HI: tu user
        Welcoming(); 




        //Taking name of file from the user
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("      Input name of the file you want to save your list of students ");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine();
        Console.Write("Input here:   ");
        nameOfFile = Console.ReadLine();
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.WriteLine("                         Press ENTER to confirm");
        Console.WriteLine("----------------------------------------------------------------------------");
        Console.ReadKey();
        Console.Clear();


        //Checking if name of file is good enought
        if (nameOfFile != null || nameOfFile == " ")
        {

            //Creating a name of file
            nameOfFile.ToString();
            string filename = @"" + nameOfFile + ".txt"; 


            //Checking is file existing
            if (File.Exists(filename))
            {
                typeOfError = 1;
                DecisionBox(typeOfError, filename);

            }


            //Getting number of students from user (array lenght)
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("                        Input number of students ");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
            Console.Write("Input here:   ");
            NumberGiven = Console.ReadLine(); //Taking number of students from user
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("                         Press ENTER to insert");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();



            //checking if number of students is a number
            if (IsItNumber(NumberGiven))
            {
                 int number = Convert.ToInt32(NumberGiven);



                //creating an array
                Students[] DataBase = new Students[number];


                //Taking all informations about students from user
                for (int i = 0; i < number; i++) 
                {
                    int id = i + 1;

                    //Heading
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("                         Student number {0} ",id);
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();


                    //Getting Student.Name 
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("                        Input Name of student ");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.Write("      Input here:   ");
                    name = Console.ReadLine();              
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.WriteLine("                         Press ENTER to insert");
                    Console.WriteLine("----------------------------------------------------------------------------");
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine();

                    // Checking if name is not a number
                    if (IsItNumber(name) == false) 
                    {


                        //Getting Student.SurName
                        Console.WriteLine("----------------------------------------------------------------------------");
                        Console.WriteLine("                    Input last name of student: ");
                        Console.WriteLine("----------------------------------------------------------------------------");
                        Console.Write("      Input here:   ");
                        surName = Console.ReadLine();
                        Console.WriteLine("----------------------------------------------------------------------------");
                        Console.WriteLine("                       Press ENTER to insert");
                        Console.WriteLine("----------------------------------------------------------------------------");
                        Console.ReadKey();
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine();



                        // Checking if Surname is not a number
                        if (IsItNumber(surName) == false)
                        {

                            //Getting Student.Grade
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.WriteLine("                     Input last grade of student: ");
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.Write("      Input here:   ");
                            grade = Console.ReadLine().ToString();
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.WriteLine("                         Press ENTER to insert");
                            Console.WriteLine("----------------------------------------------------------------------------");
                            Console.ReadKey();
                            Console.Clear();                          


                            // Checking if name is not a number
                            if (IsItNumber(grade))
                            {

                                //tranforming Students grade to clear information
                                if (Convert.ToInt32(grade)<=3)
                                {

                                    result = " Passed ";
                                }
                                else
                                {
                                    result = "Did not passed";
                                }

                                //Adding student to Students[number] DataBase  *number = NumberGiven
                                DataBase[i] = new Students(id, name, surName, grade, result);

                                //The name speaks for itself
                                AddingToFile(DataBase[i], filename);

                            }
                            
                            
                        }
                        else
                        {
                            typeOfError = 0; //0 typeOfError means wrong data type
                            DecisionBox(typeOfError, filename);
                        }


                    }
                    else
                    {
                        typeOfError = 0; //0 typeOfError means wrong data type
                        DecisionBox(typeOfError, filename);
                    }
                }
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("                           " + filename + "                                            ");
                Console.WriteLine("----------------------------------------------------------------------------");
                for (int i = 0; i < number; i++)
                {
                    //The name speaks for itself
                    ReadingFromFile(filename);
                }
                    
            }
            else
            {
                typeOfError = 0; //0 typeOfError means wrong data type
                DecisionBox(typeOfError, filename);
            }
            
        }
        else
        {

            nameOfFile.ToString();
            string filename = @"" + nameOfFile + ".txt";  //again naming a file
            typeOfError = 1; //1 typeOFError means File already exist
            DecisionBox(typeOfError, filename); 
        }



        //End of the program
        Console.ReadKey();
        Environment.Exit(0);
    }


    

    public static void AddingToFile(Students tab, string filename)
    {
        /*
                 Method adding all informations to file, we need:
                -tab -> Students[number] DataBase;
                -filename -> filename
        */
        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@filename))
        {
            file.WriteLine("Student nr:   {0}", tab.Id);
            file.WriteLine("Name:   {0}", tab.Name);
            file.WriteLine("Last name:   {0}", tab.SurName);
            file.WriteLine("Grade:   {0}",tab.Grade);
            file.WriteLine();
            file.WriteLine("Score:  {0}",tab.Result);
        }
    }
    public static void ReadingFromFile(string filename)
    {
        /*
                 Method reading all informations to file, we need:
                -filename -> filename
        */

        using(System.IO.StreamReader file = new System.IO.StreamReader(@filename))
        {
            string s = "";
            
            Console.WriteLine();
            Console.WriteLine();
            while ((s = file.ReadLine()) != null)
            {
                Console.WriteLine("          {0}     ", s);
            }
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine();
        }
    }
    public static bool IsItNumber(string str)
    {
        /*
                 Method checking is given variable is a number :
                -variable
        */



        if (int.TryParse(str, out int result))
        {
            return true;
        }
        return false;

    }
    public static void Welcoming()
    {
        /*
                 Method adding some greatings to user:
        */


        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                              Hello!");
        Console.WriteLine("       Welcome to our app, I am gonna write down and save all of informations about your students");
        Console.WriteLine("                         In next step we need you to type number of students ");
        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("                                       Press enter to continue");
        Console.ReadKey();
        Console.Clear();

    }
    public static void DecisionBox(int typeOfError, string FileName) //decision box, in future maybe renaming function or showing errors to user
    {

        /*
                 Method where all decisions are made by user
                 Here you will see typesOfError in use and uniwersal strings in messeges to user
        */
        string line1 = string.Empty;
            string line2 = string.Empty;
            string line3 = string.Empty;
            string line4 = string.Empty;
        //Unifished method:
            //contentLines(typeOfError); 

        if (typeOfError == 0)
        {
            
            line1 = "                            Please keep it right data type";
            line2 = "         If we ask for string could you give us caption, similarly with number";
            line3 = "                            Do you want to try again?";
            line4 = "";

        }
        else if (typeOfError == 1)
        {
            
            line1 = "                       File "+ FileName+ " already exist";
            line2 = "";        
            line3 = "                        Do you want to delete it?";
            line4 = "Yes = program will delete an restart, No = program will spare file and shut down";
            


        }
        else
        {
            
            line1 = "                                     Unexpected ERROR";
            line2 = "                   Sorry I think it's my dalt, maybe you wanna start again?";
            line3 = "                                 Do you want to try again?";
            line4 = "";
            

        }


        //Message to user
        Console.Clear();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine(line1);
            Console.WriteLine(line2);
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine(line3);
            Console.WriteLine(line4);
            Console.Write("                           Type yes or no: ");

            //Taking reply from user
            string result = Console.ReadLine();
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.WriteLine("                         Press ENTER to insert");
            Console.WriteLine("----------------------------------------------------------------------------");
            Console.ReadKey();
            Console.Clear();


        if (IsItNumber(result)==false)
        {
            result.ToString();

            if (result == "yes" || result == "Yes" || result == "YES" || result == "y" || result == "Y")
            {
                //Restarting  program
                if (typeOfError == 1)
                {
                    File.Delete(FileName);
                }
                Main();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("                                 GOODBYE!");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.WriteLine("                         Press ENTER to continue");
                Console.WriteLine("----------------------------------------------------------------------------");
                Console.ReadKey();
                Console.Clear();
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
        }
    //Unfinished method maybe someone will help
    //I wanted it to show custom lines in DecisonBox 
    public static void contentLines(int typeOfError)
    {
        string line1 = string.Empty;
        string line2 = string.Empty;
        string line3 = string.Empty;
        string line4 = string.Empty;
        
        if (typeOfError == 1)
        {
             line1 = "                         Please keep it right data type";
             line2 = "If we ask for string could you give us caption, similarly with number";
             line3 = "                         Do you want to try again?";
             line4 = "";

        }
        else if(typeOfError == 0)
        {
             line1 = "                            File already exist";
             line2 = "";
             line3 = "                        Do you want to delete it?";
             line4 = " If you want delete it and write again program will shut down, I am still working to write extra to your file";


        }
        else
        {
             line1 = "                            Unexpected ERROR";
             line2 = "        Sorry I think it's my dalt, maybe you wanna start again?";
             line3 = "                         Do you want to try again?";
             line4 = "";

        }
        
    }

}
