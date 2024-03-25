using SolucaoDesc;
namespace TestSolucaoDesc {
    [TestClass]
    public class TestDescontos
{
    [TestMethod]
    public void TestCalcularDescontos()
    {
        float valorunit = 500;
        float desconto = 50;
        Descontos testdesc = new Descontos();

        float descfinal = testdesc.CalcularDesconto(valorunit,desconto);
        Assert.AreEqual(250,descfinal);



    }
}
}

