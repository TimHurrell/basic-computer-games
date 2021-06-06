using Train;
using System;
using Xunit;

namespace TestProcess
{
    public class TestingProcess
    {
              

        [Fact]
        public void TestInitialConditionRandomNumber()
        {
            train train = new train();
            Assert.InRange(train.randomdouble, 0.0, 1);
        }
        [Fact]
        public void TestInitialConditionCarMpH()
        {
            train train = new train();
            double test = train.carMph;
            Assert.InRange(test, 40, 65);
        }
        [Fact]
        public void TestInitialConditionHours()
        {
            train train = new train();
            double test = train.hours;
            Assert.InRange(test, 5, 20);
        }
        [Fact]
        public void TestInitialConditiontrain()
        {
            train train = new train();
            double test = train.traintime;
            Assert.InRange(test, 20, 39);
        }

        [Fact]
        public void TestCorrectAnswerToSolution()
        {
            train train = new train();
            train.hours = 6;
            train.traintime = 25;
            train.carMph = 50;
            double test = train.CorrectAnswerToSolution();
            Assert.Equal(6, test);
        }

        [Fact]
        public void TestHowCloseToCorrectAnswerToSolution()
        {
            train train = new train();
            train.hours = 6;
            train.traintime = 25;
            train.carMph = 50;
            double test = train.HowCloseToCorrectAnswerToSolution(9);
            Assert.Equal(33, test);
        }
        [Fact]
        public void TestSolutionWithoutFivePercent()
        {
            train train = new train();
            train.hours = 6;
            train.traintime = 25;
            train.carMph = 50;
            Assert.False(train.SolutionWithinFivePercent(9));
        }
        [Fact]
        public void TestSolutionWithinFivePercent()
        {
            train train = new train();
            train.hours = 6;
            train.traintime = 25;
            train.carMph = 50;
            Assert.True(train.SolutionWithinFivePercent(6));
        }

        [Fact]

        public void TestYesEnteredY()
        {
            String myline = "Y";
            train train = new train();
            train.YesEntered(myline);
            Assert.True(train.YesEntered(myline));
        }
        [Fact]
        public void TestYesEnteredYes()
        {
            String myline = "YES";
            train train = new train();
            train.YesEntered(myline);
            Assert.True(train.YesEntered(myline));
        }
        [Fact]
        public void TestYesEnteredNo()
        {
            String myline = "hhh";
            train train = new train();
            train.YesEntered(myline);
            Assert.False(train.YesEntered(myline));
        }

        [Fact]
        public void TestInitialConditionGameStatus()
        {
            train train = new train();
            Assert.False(train.gameOver);
        }

    }
}
