using System;
/*
 * Title: Workout Program
 * Author: Edward Son
 * Date: 9/5/21
 * Purpose: Challenge
 */

namespace WorkoutProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName;
            string workOutType;
            string workOutGoals;
            

            #region Welcome Page

            PrintLinesInCenter("Coaching by Edward", "***********************", "  &&&     &&&  ", " &**&     &**& ", "&***&|||||&***&", " &**&     &**& ", "  &&&     &&&  ", "", "Press enter to begin");
                Console.ReadLine();
                Console.Clear();

                #endregion

                #region Client Name
                PrintLinesInCenter("Welcome to Coaching by Edward!", "What is your name?", "");
                firstName = Console.ReadLine();
                
                
                Console.Clear();
            

                #endregion

                #region NullorEmpty for Name

                while (string.IsNullOrEmpty(firstName))
                {
                    PrintLinesInCenter("Oops, you didn't enter a name, please type your name once more: ", "");
                    firstName = Console.ReadLine();
                }
                Console.Clear();

                #endregion

                #region CBS Option

                PrintLinesInCenter($"Hi, {firstName}!", "Thank you for signing up, What would you like to workout today?", "", "Our current program includes: Chest, Back, and Arms.", "Please choose an option listed above: ", "");
                 workOutType = Console.ReadLine();
                
                #endregion

                #region NullorEmpty for CAB

                while (string.IsNullOrEmpty(firstName))
                {
                 PrintLinesInCenter($"Im sorry {firstName}, you will have to put in an input", "", "The only programs currently available are: Chest, Back, and Arms", "Which would you like to workout today?", "");
                 workOutType = Console.ReadLine();
                    
                }
                Console.Clear();

                while (!(workOutType == "chest") && !(workOutType == "back") && !(workOutType == "arms"))
                {
                    PrintLinesInCenter($"Im sorry {firstName}, our current version only supports Chest, Back, or Arms.", "", "What would you like to workout today?", "");
                workOutType = Console.ReadLine();
                }
                Console.Clear();

                #endregion

                #region EHS Option

                PrintLinesInCenter($"What are your goals {firstName}?", "", "Please choose Endurance, Hypertrophy, or Strength.", "Please choose an option listed above: ", "");
                 workOutGoals = Console.ReadLine();
                Console.Clear();

                #endregion

                #region NullorEmpty for EHS

                while (string.IsNullOrEmpty(workOutGoals))
                {
                    PrintLinesInCenter($"Im sorry {firstName}, you will have to put in an input?", "", "Is your goal Endurance, Hypertrophy, or Strength?", "");
                    workOutGoals = Console.ReadLine();
                }
                Console.Clear();

                while (!(workOutGoals == "Endurance") && !(workOutGoals == "Hypertrophy") && !(workOutGoals == "Strength"))
                {
                    PrintLinesInCenter($"Im sorry {firstName}, our current version only supports Endurance, Hypertrophy, or Strength", "", "What are your goal for today?", "");
                    workOutGoals = Console.ReadLine();
                }
                Console.Clear();

                //Selections
                Selections(workOutType, workOutGoals);

                #endregion
            
        }

        
        #region LinesinCenter
        public static void PrintLinesInCenter(params string[] lines)
        {
            int verticalStart = (Console.WindowHeight - lines.Length) / 2; // work out where to start printing the lines
            int verticalPosition = verticalStart;
            foreach (var line in lines)
            {
                // work out where to start printing the line text horizontally
                int horizontalStart = (Console.WindowWidth - line.Length) / 2;
                // set the start position for this line of text
                Console.SetCursorPosition(horizontalStart, verticalPosition);
                // write the text
                Console.Write(line);
                // move to the next line
                ++verticalPosition;
            }
        }
        #endregion

        #region Selections
        
        public static void Selections(string workOutType, string workOutGoals)
        {

            if (workOutType == "Arms" && workOutGoals == "Endurance")
            {

                AssignToArmsEndurance();
                
            }

            else if (workOutType == "Arms" && workOutGoals == "Hypertrophy")
            {
                AssignToArmsHypertrophy();
                
            }

            else if (workOutType == "Arms" && workOutGoals == "Strength")
            {
                AssignToArmsStrength();
               
            }

            if (workOutType == "Back" && workOutGoals == "Endurance")
            {
                AssignToBackEndurance();
                
            }

            else if (workOutType == "Back" && workOutGoals == "Hypertrophy")
            {
                AssignToBackHypertrophy();
               
            }

            else if (workOutType == "Back" && workOutGoals == "Strength")
            {
                AssignToBackStrength();
               
            }

            if (workOutType == "Chest" && workOutGoals == "Endurance")
            {
                AssignToChestEndurance();
                
            }

            else if (workOutType == "Back" && workOutGoals == "Hypertrophy")
            {
                AssignToBackHypertrophy();
                
            }
            else if (workOutType == "Chest" && workOutGoals == "Hypertrophy")
            {
                AssignToChestHypertrophy();
                
            }
            else if (workOutType == "Chest" && workOutGoals == "Strength")
            {
                AssignToChestStrength();
                
            }



        }
        #endregion

        #region Assign to Chest

        public static void AssignToChestEndurance()
        {

            Chest CE = new Chest();
            CE.Endurance();
        }
        public static void AssignToChestHypertrophy()
        {

            Chest CH = new Chest();
            CH.Hypertrophy();
        }
        public static void AssignToChestStrength()
        {
            
            Chest CS = new Chest();
            CS.Strength();
        }
        #endregion

        #region Assign to Back

        public static void AssignToBackEndurance()
        {

            Back BE = new Back();
            BE.Endurance();
        }
        public static void AssignToBackHypertrophy()
        {


            Back BH = new Back();
            BH.Hypertrophy();
        }
        public static void AssignToBackStrength()
        {

            Back BS = new Back();
            BS.Strength();
        }
        #endregion

        #region Assign to Arms

        public static void AssignToArmsEndurance()
        {

            Arms AE = new Arms();
            AE.Endurance();
        }
        public static void AssignToArmsHypertrophy()
        {


            Arms AH = new Arms();
            AH.Hypertrophy();
        }
        public static void AssignToArmsStrength()
        {


            Arms AS = new Arms();
            AS.Strength();
        }
        #endregion
    }
}




#region Questions
//Is there a way to use allow the use of my var name in other classes?
#endregion





#region Header
//Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "Coaching by Edward"));
//Console.WriteLine(String.Format("{0," + Console.WindowWidth / 2 + "}", "******************"));
//Console.WriteLine();
#endregion

#region CBS Option

//Console.WriteLine($"Hi, {name}!, thank you for signing up, what would you like to workout today?");
//Console.WriteLine();
//Console.WriteLine("Our current program includes: Chest, Back, and Arms.");
//Console.WriteLine("Please choose an option listed above: ");
//Console.WriteLine(); 
#endregion

#region EHS Option
//Console.WriteLine();
//Console.WriteLine($"What are your goals {name}?, Please choose Endurance, Hypertrophy, or Strength.");
//Console.WriteLine(); 
#endregion





//if else statements and logic
//IO create to text


//dowhile loops. special while that goes through once and then checks for condition
//asking if you wnat to doit again.'

//create new backing field max health in the ability
//put it in combat.
//change logic so that max health is used instead of player hjealth

//edit it in slayers class.







//workout = class console.WriteLine("What would you like to workout today?")
//SETS (3[endurance], 4[hypertrophy], 5[strength]), 
//REPS 5[strength], 8[hypertrophy], 12[endurance],
//intensity[user input] - Different properties for each exercise? that inherit from workouts
//chest = object that features bench, DB bench, flys
//back = object that features lat PD, DB rows, PU
//arms = object that features DB curls, Tri PD, DB S press

//gaurdrails could include if they already worked it out
//different exercises can be the overload
//override can happen in the sets and reps or exercises
//hidden???



//How many calories do I need?
//
//sex, age, height, weight, activity level,
//
//goals (lose weight TDEE-(bodyweight X .500) , gain weight TDEE(bodyweight X 50) , maintain weight
//
//User Input height in inches so int 67
////height needs to be converted to CM (inches x 2.54)
//
//User Input weight in lbs so decimal or double 155.50lbs
////weight needs to be converted to kg from user input (lb/2.2046)
//
//Resting energy expenditure ( represents the amount of calories required. for a 24-hour period by the body during a non-active period)
//REE is calculated:
//for male : 10 x weight (kg) + 6.25 x height (cm) – 5 x age (years) + 5
//for female: REE = 10 x weight (kg) + 6.25 x height (cm) – 5 x age (years) – 161
//
//activity level(1.2 little or 0), 1.375 (light or 1-4),  1.55(moderate or 5-7), 1.725(hard 8-12), 1.9 (12+ times)
//
//
//REE x AL = TDEE
