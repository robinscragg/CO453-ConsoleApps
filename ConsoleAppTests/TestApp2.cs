using ConsoleAppProject.App02;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace TestApp2
{
    [TestClass]
    public class TestApp2
    {
        [TestMethod]

        public void TestUnderweightMinImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 7;
            bmiTest.WeightPounds = 2;

            bmiTest.HeightFeet = 6;
            bmiTest.HeightInches = 4;

            bmiTest.CalculateBMI();

            double expectedBMI = 12;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestUnderweightMinMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 45.5;

            bmiTest.Height = 1.93;

            bmiTest.CalculateBMI();

            double expectedBMI = 12;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestUnderweightMaxImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 7;
            bmiTest.WeightPounds = 2;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 2;

            bmiTest.CalculateBMI();

            double expectedBMI = 18;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestUnderweightMaxMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 45.5;

            bmiTest.Height = 1.574;

            bmiTest.CalculateBMI();

            double expectedBMI = 18;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestNormalMinImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 7;
            bmiTest.WeightPounds = 2;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 19;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestNormalMinMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 45.5;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 19;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestNormalMaxImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 8;
            bmiTest.WeightPounds = 13;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 24;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestNormalMaxMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 56.8;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 24;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestOverweightMinImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 9;
            bmiTest.WeightPounds = 4;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 25;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestOverweightMinMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 70.5;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 30;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestOverweightMaxImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 10;
            bmiTest.WeightPounds = 10;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 29;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestOverweightMaxMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 68.2;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 29;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestObese1MinImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 11;
            bmiTest.WeightPounds = 1;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 30;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestObese1MinMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 70.5;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 30;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestObese1MaxImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 12;
            bmiTest.WeightPounds = 7;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 34;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestObese1MaxMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 79.5;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 34;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestObese2MinImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 12;
            bmiTest.WeightPounds = 12;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 35;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }


        [TestMethod]
        public void TestObese2MinMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 81.8;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 35;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestObese2MaxImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 14;
            bmiTest.WeightPounds = 4;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 39;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]
        public void TestObese2MaxMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 90.9;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 39;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestObese3MinImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 14;
            bmiTest.WeightPounds = 9;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 40;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]
        public void TestObese3MinMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 93.2;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 40;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }

        [TestMethod]

        public void TestObese3MaxImperial()
        {
            BMI bmiTest = new BMI();

            bmiTest.WeightStones = 15;
            bmiTest.WeightPounds = 5;

            bmiTest.HeightFeet = 5;
            bmiTest.HeightInches = 0;

            bmiTest.CalculateBMI();

            double expectedBMI = 41;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }


        [TestMethod]
        public void TestObese3MaxMetric()
        {
            BMI bmiTest = new BMI();

            bmiTest.Weight = 97.7;

            bmiTest.Height = 1.524;

            bmiTest.CalculateBMI();

            double expectedBMI = 42;
            Assert.AreEqual(expectedBMI, bmiTest.Bmi);
        }






    }
}
