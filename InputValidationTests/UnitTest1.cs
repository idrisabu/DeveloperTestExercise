using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using InputValidation;

namespace InputValidationTests
{
    [TestClass]
    public class UnitTest1
    {
        private Validation _inputValidation;

        [TestInitialize]
        public void TestInitialize()
        {
            _inputValidation = new Validation(new FunctionalityArgumentsValidator());
        }

        [TestMethod]
        public void InputValidation_NumberOfArgumntsNotTwo_ReturnsFalse()
        {
            //Arrange
            string[] consoleInput = new string[1];
            consoleInput[0] = "–v";

            //Act

            var validartionResult = _inputValidation.ValidInput(consoleInput);

            //Assert
            Assert.IsFalse(validartionResult);
        }

        [TestMethod]
        public void InputValidation_NumberOfArgumntsNotTwo_ReturnsTrue()
        {
            //Arrange
            string[] consoleInput = new string[2];
            consoleInput[0] = "–v";
            consoleInput[1] = @"c:/test.txt";

            //Act

            var validartionResult = _inputValidation.ValidInput(consoleInput);

            //Assert
            Assert.IsTrue(validartionResult);
        }

        [TestMethod]
        public void InputValidation_FirstArgumentIsNotPartOfToExpectedSet_ReturnsFalse()
        {
            //Arrange
            string[] consoleInput = new string[2];
            consoleInput[0] = "–m";
            consoleInput[1] = @"c:/test.txt";

            //Act

            var validartionResult = _inputValidation.ValidInput(consoleInput);

            //Assert
            Assert.IsFalse(validartionResult);
        }


        [TestMethod]
        public void InputValidation_FirstArgumentIsPartOfToExpectedSet_ReturnsTrue()
        {
            //Arrange
            string[] consoleInput = new string[2];
            consoleInput[0] = "--size";
            consoleInput[1] = @"c:/test.txt";

            //Act

            var validartionResult = _inputValidation.ValidInput(consoleInput);

            //Assert
            Assert.IsTrue(validartionResult);
        }


        [TestMethod]
        public void InputValidation_SecondArgumentIsNotAValidFilePath_ReturnsFalse()
        {
            //Arrange
            string[] consoleInput = new string[2];
            consoleInput[0] = "–v";
            consoleInput[1] = @":/test.txt";

            //Act

            var validartionResult = _inputValidation.ValidInput(consoleInput);

            //Assert
            Assert.IsFalse(validartionResult);
        }



        [TestCleanup]
        public void TestCleanup()
        {
            _inputValidation = null;
        }
    }

}
