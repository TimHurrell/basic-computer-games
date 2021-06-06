using System;

namespace Train
{
   
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
            gameOver = false;
            randomdouble = RandomGenerator();
            carMph = (int)(25 * randomdouble + 40);
            hours = (int)(15 * randomdouble + 5);
            traintime = (int)(19 * randomdouble + 20);
        }

        //public void Process()
        //{

        //    Intro();

        //    //Boolean gameOver = false;


        //    do
        //    {
   

        //        //Question();

        //        double howLong = Double.Parse(DisplayTextAndGetInput("HOW LONG DOES THE TRIP TAKE BY CAR? "));

        //        double hoursAnswer = hours * train / (carMph - train);
        //        int percentage = (int)(Math.Abs((hoursAnswer - howLong) * 100 / howLong) + .5);
        //        if (percentage > 5)
        //        {
        //            Console.WriteLine("SORRY.  YOU WERE OFF BY " + percentage + " PERCENT.");
        //        }
        //        else
        //        {
        //            Console.WriteLine("GOOD! ANSWER WITHIN " + percentage + " PERCENT.");
        //        }
        //        Console.WriteLine("CORRECT ANSWER IS " + hoursAnswer + " HOURS.");

        //        Console.WriteLine();
        //        if (!YesEntered(DisplayTextAndGetInput("ANOTHER PROBLEM (YES OR NO)? ")))
        //        {
        //            gameOver = true;
        //        }

        //    } while (!gameOver);


        //}


        public double RandomGenerator()
        {
            double number;
            Random rnd = new Random();
            number = rnd.NextDouble();
            return number;
        }




        private string DisplayTextAndGetInput(string text)
        {
            Console.WriteLine(text);
            return Console.ReadLine();
        }

       
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

        public double HowCloseToCorrectAnswerToSolution(int howLong)
        {
            return (int)(Math.Abs((CorrectAnswerToSolution() - howLong) * 100 / howLong) + .5);
        }

        public double CorrectAnswerToSolution()
        {
            return hours* traintime / (carMph - traintime);
        }

        public bool SolutionWithinFivePercent(int howLong)
        {
            return HowCloseToCorrectAnswerToSolution(howLong) < 5;
        }




    }

}
