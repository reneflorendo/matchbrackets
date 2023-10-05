using MatchingBracketsConsoleApp;

using NUnit.Framework;

namespace MatchingBracketsTests
{
    public class MatchingBracketsTests
    {
        private MatchingBrackets _matchingBrackets;

        [SetUp]
        public void SetUp()
        {
            _matchingBrackets = new MatchingBrackets();
        }

        [Test]
        public void HasMatchingBrackets_ValidInputWithMatchingBrackets_ReturnsTrue()
        {
            //Arrange
            string text = "{}";

            //Act
            bool result = _matchingBrackets.HasMatchingBrackets(text);

            //Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void HasMatchingBrackets_InvalidInputWithNonMatchingBrackets_ReturnsFalse()
        {
            //Arrange
            string text = "}{";

            //Act
            bool result = _matchingBrackets.HasMatchingBrackets(text);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void InvalidInputWithUnmatchedOpeningBrackets_ReturnsFalse()
        {
            //Arrange
            string text = "{{}";

            //Act
            bool result = _matchingBrackets.HasMatchingBrackets(text);

            //Assert
            Assert.IsFalse(result);
        }

        [Test]
        public void HasMatchingBracketsReg1_EmptyInput_ReturnsTrue()
        {
            // Arrange
            string text = "";

            // Act
            bool result = _matchingBrackets.HasMatchingBrackets(text);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void HasMatchingBracketsReg1_ValidInputWithTextInBetweenBrackets_ReturnsTrue()
        {
            // Arrange
            string text = "{abc...xyz}";

            // Act
            bool result = _matchingBrackets.HasMatchingBrackets(text);

            // Assert
            Assert.IsTrue(result);
        }

    }
}