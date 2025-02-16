using GithubLibrary;

namespace TestProject;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
        var d = DateTime.Now;
        var c = new Class1();
        Assert.AreEqual("Hello World!", c.GetHelloWorld());
    }
    
    [TestMethod]
    public void TestMethod2()
    {
        var c = new Class1();
        Assert.AreEqual(3, c.Sum(1, 2));
    }
    
    [TestMethod]
    public void TestMethod3()
    {
        var d = DateTime.Now;
        var c = new Class1();
        Assert.AreEqual(6, c.Multiply(2, 3));
    }
}