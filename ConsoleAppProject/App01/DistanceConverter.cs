using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Converts between different distances
    /// </summary>
    /// <author>
    /// Andrew Stephenson version 0.1
    /// </author>
    public class DistanceConverter
    {
        private double miles;
        private double feet;
        
        ///<summary>
        ///</summary>
        public void Run()
        {
            InputMiles();
            CalculateFeet();
            OutputFeet();
        }

        ///<summary>
        /// Prompt the user to enter the distance in miles
        /// Input the miles as a double number
        ///</summary>
        private void InputMiles()
        {
            Console.Write("Please enter the number of miles >");
            string value = Console.ReadLine();
            miles = Convert.ToDouble(value);
        }

        ///<summary>
        ///</summary>
        private void CalculateFeet()
        {
            feet = miles * 5280;
        }

        ///<summary>
        ///</summary>
        private void OutputFeet()
        {
            Console.WriteLine(miles + " miles is " + feet + "feet!");
        }
    }

}
