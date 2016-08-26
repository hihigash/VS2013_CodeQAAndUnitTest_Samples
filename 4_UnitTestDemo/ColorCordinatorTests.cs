using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _4_UnitTestDemo
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class ColorCordinatorTests
    {
        [TestMethod]
        //[TestCategory("Unit Test Sample")]
        //[Priority(1)]
        //[Owner("Team Blue")]
        public void SuggestMyShirtColor_Suggest_Pink_Shirt_If_Pants_Are_Red()
        {
            // Arrange
            var colorCordinator = new ColorCordinator();

            // Act
            var actual = colorCordinator.SuggestMyShirtColor(Color.Red);

            // Assert
            Assert.AreEqual(Color.Pink, actual);
        }
    }
}
