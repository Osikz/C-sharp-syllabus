using System.Collections.Generic;
using NUnit.Framework;

namespace WordCount.Tests
{
    public class Tests
    {
        [Test]
        public void LineCounter_RandomText_ExpectedTrue()
        {
            //Arrange
            var text = "one two three asdfasfasdf ff";
            var textList = new List<string>();

            //Act
            textList.Add(text);

            //Assert
            Assert.AreEqual(Methods.LineCounter(textList), 1);
        }

        [Test]
        public void WordCounter_RandomTextWithApostrophe_ExpectedTrue()
        {
            //Arrange
            var text = "one two three asdfas'fasdf ff";
            var textList = new List<string>();

            //Act
            textList.Add(text);

            //Assert
            Assert.AreEqual(Methods.WordCounter(textList), 6);
        }

        [Test]
        public void LetterCounter_RandomText_ExpectedTrue()
        {
            //Arrange
            var text = "one two three asdfasfasdf ff";
            var textList = new List<string>();

            //Act
            textList.Add(text);

            //Assert
            Assert.AreEqual(Methods.LetterCounter(textList), 24);
        }
    }
}