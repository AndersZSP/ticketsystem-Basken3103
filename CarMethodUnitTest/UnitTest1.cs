




using TicketSystemClassLibrary;

namespace CarMethodUnitTest;

[TestClass]
public class UnitTest1
{
    Car car = new Car();

    [TestMethod]
    [DataRow(240)]
    public void TestMethod1(double value)
    {
        //Arrange
        


        //Act
        Double Price = car.Price();


        //Assert
        Assert.AreEqual(240, Price);
    }

    [TestMethod]
    [DataRow("Car")]
    public void TestMethod2(string value)
    {
        //Arrange
        

        //Act
        string vehicle = car.Vehicle(); 


        //Assert
        Assert.AreEqual(value, vehicle);
    }













}