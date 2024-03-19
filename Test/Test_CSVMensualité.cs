namespace CredImmo.Tests;

public class Test_CSVMensualite
{
	[Theory]
	[InlineData(1, 484.3, 51820.1)]
	public void CSVMensualite_Valeurs(int numero, double rembourse, double restant)
	{
		CSV output = new CSV();
		string csvMensualite = output.Mensualite(numero, rembourse, restant);

		Assert.Equal($"", csvMensualite);
	}
}