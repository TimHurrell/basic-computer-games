using System;
using System.Collections.Generic;

namespace Console2
{


    /**
     * train
     * <p>
     * Based on the Basic program train here
     * https://github.com/coding-horror/basic-computer-games/blob/main/91%20train/train.bas
     * <p>
     * Note:  The idea was to create a version of the 1970's Basic program in Java, without introducing
     * new features - no additional text, error checking, etc has been added.
     */
    public class train
    {
        public bool gameOver { get; set; }
        public double randomdouble { get; set; }
        public double carMph { get; set; }
        public double hours { get; set; }
        public double traintime { get; set; }

        //private sealed Scanner kbScanner;


        //public Boolean gameOver;

        public train()
        {
            Boolean gameOver = false;
            randomdouble = RandomGenerator();
            carMph = (int)(25 * randomdouble + 40);
            hours = (int)(15 * randomdouble + 5);
            traintime = (int)(19 * randomdouble + 20);
        }

        public void Process()
        {

            Intro();

            //Boolean gameOver = false;


            do
            {
                //Random rnd = new Random();
                //double randomdouble = RandomGenerator();
                double randomdouble = RandomGenerator();
                double carMph = (int)(25 * randomdouble + 40);
                double hours = (int)(15 * randomdouble + 5);
                double train = (int)(19 * randomdouble + 20);



                Console.WriteLine(" A CAR TRAVELING " + (int)carMph + " MPH CAN MAKE A CERTAIN TRIP IN");
                Console.WriteLine((int)hours + " HOURS LESS THAN A train TRAVELING AT " + (int)train + " MPH.");

                //Question();

                double howLong = Double.Parse(DisplayTextAndGetInput("HOW LONG DOES THE TRIP TAKE BY CAR? "));

                double hoursAnswer = hours * train / (carMph - train);
                int percentage = (int)(Math.Abs((hoursAnswer - howLong) * 100 / howLong) + .5);
                if (percentage > 5)
                {
                    Console.WriteLine("SORRY.  YOU WERE OFF BY " + percentage + " PERCENT.");
                }
                else
                {
                    Console.WriteLine("GOOD! ANSWER WITHIN " + percentage + " PERCENT.");
                }
                Console.WriteLine("CORRECT ANSWER IS " + hoursAnswer + " HOURS.");

                Console.WriteLine();
                if (!YesEntered(DisplayTextAndGetInput("ANOTHER PROBLEM (YES OR NO)? ")))
                {
                    gameOver = true;
                }

            } while (!gameOver);


        }


        public double RandomGenerator()
        {
            double number;
            Random rnd = new Random();
            number = rnd.NextDouble();
            return number;
        }



        private void Intro()
        {
            Console.WriteLine("train");
            Console.WriteLine("CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY");
            Console.WriteLine();
            Console.WriteLine("TIME - SPEED DISTANCE EXERCISE");
            Console.WriteLine();
        }

        //public Question()
        //{
        //    Random rnd = new Random();
        //    double carMph = (int)(25 * rnd.NextDouble() + 40);
        //    double hours = (int)(15 * rnd.NextDouble() + 5);
        //    double train = (int)(19 * rnd.NextDouble() + 20);
        //    var listofdata = new List<double>() { carMph, hours, train };
        //    Console.WriteLine(" A CAR TRAVELING " + (int)carMph + " MPH CAN MAKE A CERTAIN TRIP IN");
        //    Console.WriteLine((int)hours + " HOURS LESS THAN A train TRAVELING AT " + (int)train + " MPH.");
        //    return listofdata;
        //}





        /*
         * Print a message on the screen, then accept input from Keyboard.
         *
         * @param text message to be displayed on screen.
         * @return what was typed by the player.
         */

        private string DisplayTextAndGetInput(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

        /**
         * Checks whether player entered Y or YES to a question.
         *
         * @param text player string from kb
         * @return true of Y or YES was entered, otherwise false
         */
        public bool YesEntered(string text)
        {
            //Ternary (don't need 'true'/'false' expression

            //Write test for this



            if (text.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
            { return true; }
            else if (text == "YES")
            { return true; }
            else
            { return false; }
        }

        /**
         * Check whether a string equals one of a variable number of values
         * Useful to check for Y or YES for example
         * Comparison is case insensitive.
         *
         * @param text   source string
         * @param values a range of values to compare against the source string
         * @return true if a comparison was found in one of the variable number of strings passed
         */


        /**
         * Program startup.
         *
         * @param args not used (from command line).
         */
        public static void Main(String[] args)
        {
            train train = new train();
            train.Process();
        }
    }



}
