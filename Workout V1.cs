using System;
using System.Collections.Generic;
using System.Text;

namespace WorkoutProgram
{
    abstract class Workouts
     {
        

        #region Backing Fields
        private static string _FirstName;
        private string _LastName;

        //public static string FirstName 
       // {
            //how to turn name into lower.
            //get { return _FirstName.ToLower(); }
            //set { _FirstName = value; }
       // }
        public string LastName { get => _LastName; set => _LastName = value; }

        public Workouts()
        {
           // _FirstName = FirstName;
        }

        #endregion

        #region Empty Abstract Methods

        abstract public void Endurance();

        abstract public void Hypertrophy();

        abstract public void Strength();


        #endregion

     }
    
}