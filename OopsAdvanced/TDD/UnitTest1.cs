namespace TDD;
[TestFixture]
public class Tests
{
    Maths operation=null; 
    Maths operation1=null;
    Maths operation2=null;
    [SetUp]
    public void Setup()
    {
        operation=new Maths();
        operation1=new Maths();
        operation2=new Maths();

    }

    [Test]//single test case
    public void Test1()
    {
        int result=operation.Addition(10,11);
        Assert.That(result,Is.EqualTo(21));
    }

    [TestCase(10,20,30)]
    [TestCase(1,2,3)]
   
    public void IsAdded(int value1, int value2,int result)
    {
        int output=operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
    
    [TestCase(1.2,3.2,4.4)]
    
     public void IsAdded(double value1, double value2,double  result)
    {
        double output=operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }
    [TestCase("siva","sankar","sivasankar")]
    
     public void IsAdded(string value1, string  value2,string result)
    {
        string output=operation.Addition(value1,value2);
        Assert.AreEqual(output,result);
    }

}