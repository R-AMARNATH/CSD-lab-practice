using BMICalculator;

namespace bmi2025lab.Teats
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void BMICategory_ShouldReturnNormal_ForHealthyBMI()
        {
            // Arrange
            var bmi = new BMI
            {
                WeightStones = 11,   // ~70 kg
                WeightPounds = 0,
                HeightFeet = 5,
                HeightInches = 8
            };

            // Act
            var category = bmi.BMICategory;

            // Assert
            Assert.AreEqual(BMICategory.Normal, category, "BMI category should be Normal");
        }
    }
}
