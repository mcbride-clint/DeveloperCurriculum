using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleLibrary.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Arrange
            var expected = 6;

            // Act
            var actual = BasicMath.Add(1, 2, 3);

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
