using System;
using System.Collections.Generic;
using Train;

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
    class mainconsole
    {
       

        public void Process()
        {

            Intro();

            Boolean gameOver = false;


            do
            {
                train train = new train();



                InformationAboutJourney(train);

                double howLong = Double.Parse(DisplayTextAndGetInput("HOW LONG DOES THE TRIP TAKE BY CAR? "));

                train.SolutionWithinFivePercent(howLong);

                if (train.SolutionWithinFivePercent(howLong) is false)
                {
                    Console.WriteLine("SORRY.  YOU WERE OFF BY " + train.HowCloseToCorrectAnswerToSolution(howLong) + " PERCENT.");
                }
                else
                {
                    Console.WriteLine("GOOD! ANSWER WITHIN " + train.HowCloseToCorrectAnswerToSolution(howLong) + " PERCENT.");
                }
                Console.WriteLine("CORRECT ANSWER IS " + train.CorrectAnswerToSolution() + " HOURS.");

                Console.WriteLine();
                if (!train.YesEntered(DisplayTextAndGetInput("ANOTHER PROBLEM (YES OR NO)? ")))
                {
                    gameOver = true;
                }

            } while (!gameOver);


        }





        private void Intro()
        {
            Console.WriteLine("train");
            Console.WriteLine("CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY");
            Console.WriteLine();
            Console.WriteLine("TIME - SPEED DISTANCE EXERCISE");
            Console.WriteLine();
        }

        private void InformationAboutJourney(train train)
        {

            Console.WriteLine(" A CAR TRAVELING " + (int)train.carMph + " MPH CAN MAKE A CERTAIN TRIP IN");
            Console.WriteLine((int)train.hours + " HOURS LESS THAN A train TRAVELING AT " + (int)train.traintime + " MPH.");

        }





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
       
    }

      */
        public static void Main(String[] args)
        {
            Process process = new Process();
        }



    }
