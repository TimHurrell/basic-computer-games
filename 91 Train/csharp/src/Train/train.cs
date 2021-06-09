using System;

namespace Train
{
   
    public class train
    {
        public double randomdouble { get; set; }
        public double carMph { get; set; }
        public double hours { get; set; }
        public double Traintime { get; set; }
        public int Threshold { get; set; }
        public bool IsCloseToCorrectAnswer { get; set; }
        public int PercentageProximityToAnswer { get; set; }
        public double CorrectAnswerToProblem { get; set; }


        public train()
        {
            randomdouble = RandomGenerator();
            carMph = (int)(25 * randomdouble + 40);
            hours = (int)(15 * randomdouble + 5);
            Traintime = (int)(19 * randomdouble + 20);
            Threshold = 5;
        }

       

        public double RandomGenerator()
        {
            double number;
            Random rnd = new Random();
            number = rnd.NextDouble();
            return number;
        }


               
        public bool YesEntered(string text)
        {
           


            if (text.Equals("Y", StringComparison.InvariantCultureIgnoreCase) || text.Equals("YES", StringComparison.InvariantCultureIgnoreCase))
            { return true; }
            else
            { return false; }
        }

        public double HowCloseToCorrectAnswerToSolution(double howLong)
        {
            return PercentageProximityToAnswer = (int)(Math.Abs((CorrectAnswerToSolution() - howLong) * 100 / howLong) + .5);
        }

        public double CorrectAnswerToSolution()
        {
            return CorrectAnswerToProblem = hours * Traintime / (carMph - Traintime);
        }

        public bool SolutionWithinThreshold(double howLong)
        {
            return IsCloseToCorrectAnswer = HowCloseToCorrectAnswerToSolution(howLong) < Threshold;
        }




    }

}
