using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowFast
{
    class SpeedProvider
    {
        /// <summary>
        /// Convert Miles Per Hour to Kilometers Per Hour
        /// </summary>
        /// <param name="speedInMPH">Miles per hour as a whole number</param>
        /// <returns>Returns Kilometers per hour as a whole number</returns>
        public static int ConvertMPHtoKPH(int speedInMPH)
        {
            return (int)Math.Round(speedInMPH * 1.609344, 0);
        }

        /// <summary>
        /// Calculates Speed based on distance in miles and minutes until your appointment
        /// </summary>
        /// <param name="distanceInMiles">Distance as a decimale</param>
        /// <param name="minutesLeft">Minutes as a decimal</param>
        /// <returns>Speed in MPH as a whole number</returns>
        public static int RequiredSpeedInMPH(decimal distanceInMiles, decimal minutesLeft)
        {
            int requiredSpeed = 0; //initialize a variable for the calculated speed to return/

            decimal amountOfHours = minutesLeft / 60; // 60 mins in an hour
            requiredSpeed = (int)Math.Round(distanceInMiles / amountOfHours, 0); //Use the Math library to round the decimal to the nearest whole number

            return requiredSpeed; //return the speed back to the function caller.
        }
    }
}
