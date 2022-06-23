// Write a program in C# Sharp to create a nested structure to store two data for an employee in an array. 
using System;
struct EmployeeStructure
{
    public string EmplName;
    public DtOfBirth EmplDateOfBirth;
}
struct DtOfBirth
{
    public int Day;
    public int Month;
    public int Year;
}
class StructExercise
{
    public static void Main()
    {
        Welcome();
        int dd = 0, mm = 0, yy = 0;
        
        Console.Write("Input number of employee to sign: ");
        string CountGiven = Console.ReadLine().ToString();
        if (IsItNumber(CountGiven))
        {
            int number = Convert.ToInt32(CountGiven);
            EmployeeStructure[] emp = new EmployeeStructure[number];
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine();
                Console.WriteLine("--- --- --- {0} EMPLOYEE --- --- ---",i+1);
                Console.Write("Insert name of an emplyee: ");
                string name = (Console.ReadLine());
                emp[i].EmplName = name;
                Console.WriteLine();

                Console.Write("Insert day of birth of an emplyee (number like 1): ");
                int day = Convert.ToInt32(Console.ReadLine());
                emp[i].EmplDateOfBirth.Day = day;
                Console.WriteLine();

                Console.WriteLine("Insert month of birth of an employee (number like 2): ");
                int month = Convert.ToInt32(Console.ReadLine());
                emp[i].EmplDateOfBirth.Month = month;
                Console.WriteLine();

                Console.WriteLine("Insert year of birth of an employee (number like 0000): ");
                int year = Convert.ToInt32(Console.ReadLine());
                emp[i].EmplDateOfBirth.Year = year;
                Console.WriteLine();
                Console.WriteLine("-------------------------------------------------------------------");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            
            for(int i = 0; i < number; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Employee number {0}: {1}", i+1, emp[i].EmplName);
                int monthCheck = emp[i].EmplDateOfBirth.Month;
                WhatMonthIsIt(monthCheck);
                Console.WriteLine("Born in {0} {1} {2}",WhatMonthIsIt(monthCheck), emp[i].EmplDateOfBirth.Day, emp[i].EmplDateOfBirth.Year);

            }

        }
        ElseFormula(CountGiven);
    }
    public static string WhatMonthIsIt(int month)
    {
        string monthname = string.Empty;
        switch (month)
        {
            case 01:
                monthname = "January";
                return monthname;
                break;
            case 02:
                monthname = "Febuary";
                return monthname;
                break;
            case 03:
                monthname = "March";
                return monthname;
                break;
            case 04:
                monthname = "April";
                return monthname;
                break;
            case 05:
                monthname = "May";
                return monthname;
                break;
            case 06:
                monthname = "June";
                return monthname;
                break;
            case 07:
                monthname = "July";
                return monthname;
                break;
            case 08:
                monthname = "August";
                return monthname;
                break;
            case 09:
                monthname = "September";
                return monthname;
                break;
            case 10:
                monthname = "October";
                return monthname;
                break;
            case 11:
                monthname = "November";
                return monthname;
                break;
            case 12:
                monthname = "December";
                return monthname;
                break;
            default:
                monthname = "IDK";
                return monthname;
                break; 
        }
        return monthname;
    }
    public static void ElseFormula(string str)
    {
        if(!(IsItNumber(str))) 
        {
            Console.WriteLine("Something gone wrong");
            Console.WriteLine("Do you want to try again?");
            Console.Write("Type yes or no: ");
            string answer = Console.ReadLine().ToString();
            answer.ToLower();
            if (answer == "yes")
            {

                Main();
            }
            else
            {
                Console.WriteLine("Are you sure?");
                Console.WriteLine("Yes or no");
                string answer2 = (Console.ReadLine()).ToString();
                answer2.ToLower();
                if (answer2 == "yes")
                {
                    Console.Clear();
                    Console.ReadKey();
                }
                else if(answer2=="no")
                {
                    Console.WriteLine("Do you want to try again?");
                    Console.WriteLine("Yes or No");
                    string answer3 = (Console.ReadLine()).ToString();
                    answer3.ToLower();
                    if (answer3 == "yes")
                    {
                        Main();
                    }
                    else
                    {
                        Console.Clear();
                        Console.ReadKey();
                    }
                }
                else
                {
                    Main();
                }
            }

        }
    }
    public static bool IsItNumber(string str)
    {
        if (int.TryParse(str, out int i))
        {
            return true;
        }
        return false;
    }

    public static void Welcome()
    {
        Console.Clear();
        Console.WriteLine("                     --- --- --- Hello! --- --- ---");
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("        Today I am gonna tell you is your number an ARMSTRONG number");
        Console.WriteLine();
        Console.WriteLine("               -- -- -- Press any key to contionue -- -- --   ");
        Console.ReadKey();
        Console.Clear();

    }
}
