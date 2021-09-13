using System;
using System.Collections.Generic;
using System.Text;

namespace Workouts
{
    abstract class Workouts
     {
        string firstName;
        string workOutType;
        string workOutGoals;

        #region Backing Fields


        public Workouts()
        {
            
        }

        #endregion

        #region Empty Abstract Methods

         abstract public void Endurance();

         abstract public void Hypertrophy();

         abstract public void Strength();


        #endregion

     }
    
}