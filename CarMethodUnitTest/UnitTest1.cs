
using CarLibrary;

namespace CarMethodUnitTest;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    [DataRow(240)]
    public void TestMethod1(double value)
    {
        //Arrange
        var CarPrice = new Car();


        //Act
        Double Price = Car.Price();


        //Assert
        Assert.AreEqual(240, Price);
    }

    [TestMethod]
    [DataRow("Car")]
    public void TestMethod2(string value)
    {
        //Arrange
        var VehicleType = new Car();


        //Act
        string vehicle = Car.VehicleType(); 


        //Assert
        Assert.AreEqual(value, "Car");
    }













}