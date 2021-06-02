using System;
using System.IO;
using System.Text;

namespace Console2
{


    /**
     * Train
     * <p>
     * Based on the Basic program Train here
     * https://github.com/coding-horror/basic-computer-games/blob/main/91%20Train/train.bas
     * <p>
     * Note:  The idea was to create a version of the 1970's Basic program in Java, without introducing
     * new features - no additional text, error checking, etc has been added.
     */
    public class Train
    {

        //private sealed Scanner kbScanner;




        //      public Train()
        //  {
        //      string str = Console.ReadLine();
        //      kbScanner = new Scanner(str);
        //  }

        public void Process()
        {

            Intro();

            Boolean gameOver = false;


            do
            {
                Random rnd = new Random();
                double carMph = (int)(25 * rnd.NextDouble() + 40);
                double hours = (int)(15 * rnd.NextDouble() + 5);
                double train = (int)(19 * rnd.NextDouble() + 20);


                Console.WriteLine(" A CAR TRAVELING " + (int)carMph + " MPH CAN MAKE A CERTAIN TRIP IN");
                Console.WriteLine((int)hours + " HOURS LESS THAN A TRAIN TRAVELING AT " + (int)train + " MPH.");

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

        private void Intro()
        {
            Console.WriteLine("TRAIN");
            Console.WriteLine("CREATIVE COMPUTING  MORRISTOWN, NEW JERSEY");
            Console.WriteLine();
            Console.WriteLine("TIME - SPEED DISTANCE EXERCISE");
            Console.WriteLine();
        }

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
        private Boolean YesEntered(String text)
        {
            //Ternary (don't need 'true'/'false' expression

            //Write test for this

            if (text == "Y")
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
        //private Boolean StringIsAnyValue(String text, params string[] values)
        //{
        //    // byte[] byteArray = Encoding.ASCII.GetBytes(values);
        //    // MemoryStream stream = new MemoryStream(byteArray);

        //    return Arrays.stream(values).anyMatch(str->str.equalsIgnoreCase(text));

        //}

        /**
         * Program startup.
         *
         * @param args not used (from command line).
         */
        public static void Main(String[] args)
        {
            Train train = new Train();
            train.Process();
        }
    }

}
