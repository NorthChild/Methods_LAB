using System;

namespace Methods_Lib
{
    public class Methods
    {   
            
            // 2 / 4 DONE
            // DONE
        // implement this method so it returns a tuple (weeks, days) 
        // corresponding to a given number of days
        public static (int weeks, int days) DaysAndWeeks(int totalDays)
        {

            if (totalDays < 0) 
            {
                throw new ArgumentOutOfRangeException("totalDays must not be negative");
            }

            int weeksRes = totalDays / 7;
            var daysRes = totalDays % 7;

            return (weeksRes, daysRes);

        }
            
            // DONE

        // returns square (an int)
        // cube(an int)  
        // and square root(a double)
        public static (int square, int cube, double sqrRoot) GiveMeATuple(int num) 
        {
            int sqr = (num * num);
            int cbe = (num * num * num);
            double sqrRt = Math.Sqrt(num);

            return (sqr, cbe, sqrRt);
        }

            // 

        public static int RollDice(Random rng)
        {
            var num1 = rng.Next(1, 7);
            var num2 = rng.Next(1, 7);
            var Result = num1 + num2;

            if (Result > 12 || Result < 1) 
            {
                throw new ArgumentOutOfRangeException("answer out of range of 2d6");
            }

            return Result;
        }

    }
}
