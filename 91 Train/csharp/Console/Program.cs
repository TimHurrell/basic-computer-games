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
                double howLong = Double.Parse(GetInputAnswerToProblem());
                train.SolutionWithinThreshold(howLong);
                DisplayHowCloseToCorrectAnswer(train);
                DisplayAnotherProblem();

                if (!train.YesEntered(GetInputAnswerToWantAnotherGame()))
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
            Console.WriteLine((int)train.hours + " HOURS LESS THAN A TRAIN TRAVELLING AT " + (int)train.Traintime + " MPH.");
            Console.WriteLine();
            Console.WriteLine("HOW LONG DOES THE TRIP TAKE BY CAR? ");

        }

        private void DisplayAnotherProblem()
        {
            Console.WriteLine();
            Console.WriteLine("ANOTHER PROBLEM (YES OR NO)? ");

        }
        private string GetInputAnswerToProblem()
        {
            return Console.ReadLine();
        }


        private void DisplayHowCloseToCorrectAnswer(train train)
        {


            if (!train.IsCloseToCorrectAnswer)
            {
                Console.WriteLine("SORRY.  YOU WERE OFF BY " + train.PercentageProximityToAnswer + " PERCENT.");
            }
            else
            {
                Console.WriteLine("GOOD! ANSWER WITHIN " + train.PercentageProximityToAnswer + " PERCENT.");
            }
            Console.WriteLine("CORRECT ANSWER IS " + train.CorrectAnswerToProblem + " HOURS.");

        }


        private string GetInputAnswerToWantAnotherGame()
        {

            return Console.ReadLine();
        }



        public static void Main(String[] args)
        {
            mainconsole mainconsole = new mainconsole();
            mainconsole.Process();

        }



    }
}
