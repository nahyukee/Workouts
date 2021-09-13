using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProgram
{
    class Arms : Workouts
    {
        #region Constructor

        public Arms()
        {
         
        }
        #endregion

        #region Declaring Methods
        public override void Endurance()
        {
            PrintLinesInCenter("Please see your workout of the day below:", "3 sets of 15 reps of Hammer Curls", "3 sets of 15 reps of Standing Overhead Triceps Extension", "3 sets of 15 reps of Barbell Curls", "3 sets of 15 reps of Barbell skull Crusher", "", "Press Enter to exit");
                    
        }
        public override void Hypertrophy()
        {
            PrintLinesInCenter("Please see your workout of the day below:", "4 sets of 10 reps of Hammer Curls", "4 sets of 10 reps of Standing Overhead Triceps Extension", "4 sets of 10 reps of Barbell Curls", "4 sets of 10 reps of Barbell skull Crusher", "", "Press Enter to exit");
                      
        }
        public override void Strength()
        {
            PrintLinesInCenter("Please see your workout of the day below:", "5 sets of 5 reps of Hammer Curls", "5 sets of 5 reps of Standing Overhead Triceps Extension", "5 sets of 5 reps of Barbell Curls", "5 sets of 5 reps of Barbell skull Crusher", "", "Press Enter to exit");
                       
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

