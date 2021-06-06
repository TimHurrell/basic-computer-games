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
            randomdouble = RandomGenerator();
            carMph = (int)(25 * randomdouble + 40);
            hours = (int)(15 * randomdouble + 5);
            traintime = (int)(19 * randomdouble + 20);
        }

       

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
           


            if (text.Equals("Y", StringComparison.InvariantCultureIgnoreCase))
            { return true; }
            else if (text == "YES")
            { return true; }
            else
            { return false; }
        }

        public double HowCloseToCorrectAnswerToSolution(double howLong)
        {
            return (int)(Math.Abs((CorrectAnswerToSolution() - howLong) * 100 / howLong) + .5);
        }

        public double CorrectAnswerToSolution()
        {
            return hours* traintime / (carMph - traintime);
        }

        public bool SolutionWithinFivePercent(double howLong)
        {
            return HowCloseToCorrectAnswerToSolution(howLong) < 5;
        }




    }

}
