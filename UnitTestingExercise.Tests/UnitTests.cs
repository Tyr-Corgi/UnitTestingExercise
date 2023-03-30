using System;
using Xunit;

namespace UnitTestingExercise.Tests
{
    public class UnitTests
    {
        [Theory]
        [InlineData(2, 3, 5, 10)] //Add test data <-------
        public void AddTest(int num1, int num2, int num3, int expected)
        {
            //Start Step 3 here:



            //Arrange
            // create a Calculator object
            Calculator challenger = new Calculator();

            //Act
                // call the Add method that is located in the Calculator class
                // and store its result in a variable named actual
            int actual = challenger.Add(num1, num2, num3);

            //Assert
                //Assert.Equal(expected, actual);
                Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(2, 2, 0)]
        [InlineData(3, 3, 0)]
        [InlineData(5, 2, 3)]
            //Add test data <-------
        public void SubtractTest(int minuend, int subtrhend, int expected)
        {
            //Start Step 5 here:

            //Arrange
            Calculator challenger = new Calculator();
                
            //Act
            int actual = minuend - subtrhend;

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(0, 0, 0)]//Add test data <-------
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 4)]
        [InlineData(3, 3, 9)]
        public void MultiplyTest(int num1, int num2, int expected)
        {
            //Start Step 7 here:

            //Arrange
            Calculator challenger = new Calculator();

            //Act
            int actual = num1 * num2;

            //Assert
            Assert.Equal(expected, actual);

        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(1, 1, 1)]
        [InlineData(2, 2, 1)]
        [InlineData(4, 2, 2)]
        [InlineData(4, 1, 4)]
        //Add test data <-------
        public void DivideTest(int numerator, int denominator, int expected)
        {
            //Arrange
            Calculator challenger = new Calculator();
            //Act
            int actual = numerator / denominator;

            //Assert
            Assert.Equal(expected, actual);

        }

    }
}
