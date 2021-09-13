using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProgram
{
     class Back : Workouts
    {
        #region Constructor

        public Back()
        {
        
        }
        #endregion

        #region Declaring Methods
        public override void Endurance()
        {
            PrintLinesInCenter("Please see your workout of the day below:", "", "3 sets of 15 reps of Lateral Pull-downs", "3 sets of 15 reps of Dumbbell rows", "3 sets of 15 reps of Seated Rows", "3 sets of AMRAP of Pull-ups", "", "Press Enter to exit");
                      
        }
        public override void Hypertrophy()
        {
            PrintLinesInCenter("Please see your workout of the day below:", "", "4 sets of 8 reps of Lateral Pull-Downs", "3 sets of 12 reps of Dumbbell rows", "3 sets of 12 reps of Chest supported rows", "3 sets of 12 reps of Lever Pull-downs", "3 sets of 12 reps of Seated Cable rows", "", "Press Enter to exit");
                       
        }
        public override void Strength()
        {
            PrintLinesInCenter("Please see your workout of the day below:","", "5 sets of 5 reps Barbell Deadlifts", "3 sets of 8 reps Barbell Bent Over Rows", "3 sets of 8 reps of Dumbbell rows", "3 sets of AMRAP of pull ups", "", "Press Enter to exit");
                        
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
