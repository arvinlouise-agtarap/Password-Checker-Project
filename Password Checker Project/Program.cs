using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password_Checker
{
    internal class Program
    {
        /* PASSWORD CRITERIA CHECKER
        * The purpose of this program is to confirm a given variable's compliance to a set of rules.
        * This project is the culmination of C# programming techniques learned by Arvin Louise Agtarap to date (Evening of 2022 March 26)
        * 
        /* [I] CRITERIA
        * The given variable will be checked for compliance against the following criteria:
        * [1] The password must be 9 to 25 digits long.
        * [2] The password must contain atleast 1 of the following characters : !,@,#,$,%,^,&,*,(,),-,=,_,+
        * [3] The password must contain atleast 1 number character
        * [4] The password must contain atleast 1 upper case letter
        * 
        /* [II] IMPORTANT VARIABLES
        *
        * string "userPass" - Main variable to save user input password to compare against criteria rules.
        * string "critOne - critX" - String variables for criteria password to be checked against. Human readable.

        */

        static void Main(string[] args)
        {
            string critOne = "The password must be 9 to 25 digits long.";
            string critTwo = "The password must contain atleast 1 of the following characters : !,@,#,$,%,^,&,*,(,),-,=,_,+";
            string critThree = "The password must contain atleast 1 number character";
            string critFour = "The password must contain atleast 1 upper case letter";
            // future criteria goes here

            // INPUT SCREEN STARTS HERE

            // Header
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("       P A S S W O R D    C H E C K E R         ");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();

            // Explains rules the password will be tested against
            Console.WriteLine("This program will confirm a given password's compliance to the following rules : ");
            Console.WriteLine($"[1] {critOne}");
            Console.WriteLine($"[2] {critTwo}");
            Console.WriteLine($"[3] {critThree}");
            Console.WriteLine($"[4] {critFour}");
            //future criteria goes here
            Console.WriteLine();

            // Acquires variable userData here
            Console.Write("Please enter a password to check : ");
            string userPass = Console.ReadLine();

            // Call Criteria Check Methods and output to Console

            // OUTPUT SCREEN STARTS HERE

            // Clear input screen
            Console.Clear();

            // Header
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("       P A S S W O R D    C H E C K E R         ");
            // User input readback
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine($"Checking : {userPass}");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine();


            Console.WriteLine(CritCheckOne(userPass, out bool passFlag1));
            Console.WriteLine(CritCheckTwo(userPass, out bool passFlag2));
            Console.WriteLine(CritCheckThree(userPass, out bool passFlag3));
            Console.WriteLine(CritCheckFour(userPass, out bool passFlag4));
            Console.WriteLine();

            // Write to console, compliance score
            Console.WriteLine($"Final Result :  {FinalResult(passFlag1, passFlag2, passFlag3, passFlag4)}");


            //** KEEPALIVE **//
            Console.ReadLine();
        }

        // Criteria Check Method 1
        // [1] The password must be 9 to 25 digits long.
        static string CritCheckOne(string userPass, out bool passFlag1)
        {
            if (userPass.Length >= 9 && userPass.Length <= 25)
            {
                passFlag1 = true;
                return "[1] : PASS";
            }
            else
            {
                passFlag1 = false;
                return "[1] : FAIL";
            }
        }

        // Criteria Check Method 2
        // [2] The password must contain atleast 1 of the following characters : !,@,#,$,%,^,&,*,(,),-,=,_,+
        static string CritCheckTwo(string userPass, out bool passFlag2)
        {
            if (userPass.Contains("!") ||
                userPass.Contains("!") ||
                userPass.Contains("@") ||
                userPass.Contains("#") ||
                userPass.Contains("$") ||
                userPass.Contains("%") ||
                userPass.Contains("^") ||
                userPass.Contains("&") ||
                userPass.Contains("*") ||
                userPass.Contains("(") ||
                userPass.Contains(")") ||
                userPass.Contains("-") ||
                userPass.Contains("_") ||
                userPass.Contains("=") ||
                userPass.Contains("+") ||
                userPass.Contains("[") ||
                userPass.Contains("{") ||
                userPass.Contains("]") ||
                userPass.Contains("}") ||
                userPass.Contains("\\") ||
                userPass.Contains("|"))
            {
                passFlag2 = true;
                return "[2] : PASS";
            }
            else
            {
                passFlag2 = false;
                return "[2] : FAIL";
            }

        }

        // Criteria Check Method 3
        // [3] The password must contain atleast 1 number character
        static string CritCheckThree(string userPass, out bool passFlag3)
        {
            if (userPass.Contains("1") ||
                userPass.Contains("2") ||
                userPass.Contains("3") ||
                userPass.Contains("4") ||
                userPass.Contains("5") ||
                userPass.Contains("6") ||
                userPass.Contains("7") ||
                userPass.Contains("8") ||
                userPass.Contains("9") ||
                userPass.Contains("0"))
            {
                passFlag3 = true;
                return "[3] : PASS";
            }
            else
            {
                passFlag3 = false;
                return "[3] : FAIL";
            }
        }

        // Criteria Check Method 4
        // [4] The password must contain atleast 1 upper case letter
        static string CritCheckFour(string userPass, out bool passFlag4)
        {
            bool upperCaseCheck = userPass.Any(char.IsUpper);
            if (upperCaseCheck == true)
            {
                passFlag4 = true;
                return "[4] : PASS";
            }
            else
            {
                passFlag4 = false;
                return "[4] : FAIL";
            }
        }


        // Method to create output strings for Final Result

        static string FinalResult(bool check1, bool check2, bool check3, bool check4)
        {
            if (
                check1 == true &&
                check2 == true &&
                check3 == true &&
                check4 == true)
            {
                return "ALL PASSED";
            }
            else
            {
                return "FAILURE";
            }
        }
    }
}
