using ConsoleAppProject.App01;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleAppTests
{
    [TestClass]
    public class TestApp1
    {
        [TestMethod]
        public void TestMilesToFeet()
        {
            DistanceConverter converter = new DistanceConverter();
                
            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 2;
            converter.CalculateDistance();

            double expectedDistance = 10560;
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestFeetToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 10560;
            converter.CalculateDistance();

            double expectedDistance = 2;
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestMilesToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Miles;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 2.0;
            converter.CalculateDistance();

            double expectedDistance = 3218.68;
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestMetresToMiles()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Miles;

            converter.FromDistance = 3218.68;
            converter.CalculateDistance();

            double expectedDistance = 2;
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestMetresToFeet()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Metres;
            converter.ToUnit = DistanceUnits.Feet;

            converter.FromDistance = 1;
            converter.CalculateDistance();

            double expectedDistance = 3.280839895013123;
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }

        [TestMethod]
        public void TestFeetToMetres()
        {
            DistanceConverter converter = new DistanceConverter();

            converter.FromUnit = DistanceUnits.Feet;
            converter.ToUnit = DistanceUnits.Metres;

            converter.FromDistance = 1;
            converter.CalculateDistance();

            double expectedDistance = 0.3048;
            Assert.AreEqual(expectedDistance, converter.ToDistance);

        }
    }
}
