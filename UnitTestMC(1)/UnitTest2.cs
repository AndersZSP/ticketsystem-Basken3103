

using MCLibrary;

namespace CarMethodUnitTest;

  [TestClass]
  public class UnitTest2
  {
        [TestMethod]
        [DataRow(125)]
        public void TestMethod1(double value)
        {
            //Arrange
            var MCPrice = new MC();


            //Act
            Double Price = MC.Price();


            //Assert
            Assert.AreEqual(125, Price);

        }

        [TestMethod]
        [DataRow("MC")]
        public void TestMethod2(string value)
        {
            //Arrange
            var Vehicle = new MC();


            //Act
            string vehicle = MC.Vehicle();


            //Assert
            Assert.AreEqual(value, "MC");
        }





}
