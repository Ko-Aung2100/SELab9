using Xunit;
using BasicMath;
namespace BasicMathTests
{
    public class CalculatorTests
    {
        // Test method for Add operation using inline data
        [Theory]
        [InlineData(1, 2, 3)] // Test case 1: 1 + 2 = 3
        [InlineData(-1, -2, -3)] // Test case 2: -1 + -2 = -3
        [InlineData(0, 0, 0)] // Test case 3: 0 + 0 = 0
        [InlineData(int.MaxValue, 1, int.MinValue)] // Test case 4: Overflow scenario
        public void Add_MultipleValues_ReturnsCorrectSum(int a, int b, int expected)
        {
            // Arrange: Create an instance of Calculator
            var calculator = new Calculator();
            // Act: Call the Add method
            double result = calculator.Add(a, b);
            // Assert: Verify the result
            Assert.Equal(expected, (int)result);
        }
        // Test method for Subtract operation using inline data
        [Theory]
        [InlineData(5, 3, 2)] // Test case 1: 5 - 3 = 2
        [InlineData(-5, -3, -2)] // Test case 2: -5 - -3 = -2
        [InlineData(0, 0, 0)] // Test case 3: 0 - 0 = 0
        [InlineData(int.MinValue+2, 1, int.MinValue + 1)] // Test case 4: Underflow scenario
        public void Subtract_MultipleValues_ReturnsCorrectDifference(int a, int b, int expected)
        {
            // Arrange: Create an instance of Calculator
            var calculator = new Calculator();
            // Act: Call the Subtract method
            double result = calculator.Subtract(a, b);
            Console.WriteLine($"Subtracting {a} - {b} = {result}");
            Console.WriteLine($"Expected: {expected}");
            // Assert: Verify the result
            Assert.Equal(expected, result);
        }
        // Test method for Multiply operation using inline data
        [Theory]
        [InlineData(2, 3, 6)] // Test case 1: 2 * 3 = 6
        [InlineData(-2, -3, 6)] // Test case 2: -2 * -3 = 6
        [InlineData(0, 5, 0)] // Test case 3: 0 * 5 = 0
        [InlineData(int.MaxValue, 1, int.MaxValue)] // Test case 4: Max value scenario
        public void Multiply_MultipleValues_ReturnsCorrectProduct(int a, int b, int expected)
        {
            // Arrange: Create an instance of Calculator
            var calculator = new Calculator();
            // Act: Call the Multiply method
            double result = calculator.Multiply(a, b);
            // Assert: Verify the result
            Assert.Equal(expected, (int)result);
        }
        // Test method for Divide operation using inline data
        [Theory]
        [InlineData(6, 3, 2)] // Test case 1: 6 / 3 = 2
        [InlineData(-6, -3, 2)] // Test case 2: -6 / -3 = 2
        [InlineData(0, 1, 0)] // Test case 3: 0 / 1 = 0
        [InlineData(int.MaxValue, 1, int.MaxValue)] // Test case 4: Max value scenario
        public void Divide_MultipleValues_ReturnsCorrectQuotient(int a, int b, int expected)
        {
            // Arrange: Create an instance of Calculator
            var calculator = new Calculator();
            // Act: Call the Divide method
            double result = calculator.Divide(a, b);
            // Assert: Verify the result
            Assert.Equal(expected, (int)result);
        }
    }
}