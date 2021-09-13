using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProgram
{
    class Chest : Workouts
    {
        #region Constructor

        public Chest()
        {
         
        }
        #endregion
                
        #region Declaring Methods
        public override void Endurance()
        {
            PrintLinesInCenter("Please see your workout of the day below:", "", "4 sets of 5 reps of Flat Barbell Bench Press", "3 sets of 15 reps of Incline Dumbbell Press", "3 sets of 15 reps of Cable Crossover", "3 sets of AMRAP Dips", "3 sets of AMRAP Pushups", "", "Press Enter to exit");
                     
        }
        public override void Hypertrophy()
        {
            PrintLinesInCenter("Please see your workout of the day below:", "", "4 sets of 8 reps of Flat Barbell Bench Press", "4 sets of 12 reps of Incline Dumbbell Press", "4 sets of 12 reps of Seated Chest Press", "2 sets of 10 reps of Decline Dumbbell Flys", "2 sets of 10 reps of Pushups", "", "Press Enter to exit");
                      
        }
        public override void Strength()
        {
            PrintLinesInCenter("Please see your workout of the day below:", "", "3 sets of 5 reps of Flat Barbell Bench Press", "3 sets of 5 reps of Incline Barbell Bench Press", "3 sets of 5 reps of Decline Barbell Bench Press", "3 sets of 5 reps of Incline Dumbbell Press", "3 sets of 5 reps of Decline Dumbbell Press", "", "Press Enter to exit");
                        
        }
        #endregion

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


    }

}