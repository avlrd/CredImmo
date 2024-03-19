namespace CredImmo.Tests;

public class Test_CSVMensualite
{
	[Theory]
	[InlineData(1, 484.3, 51820.1)]
	public void CSVMensualite_Valeurs(int numero, double rembourse, double restant)
	{
		string csvMensualite = ICSV.Mensualite(numero, rembourse, restant);

		Assert.Equal($"{numero},{rembourse},{restant}", csvMensualite);
	}
}