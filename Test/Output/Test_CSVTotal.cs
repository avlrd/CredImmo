namespace CredImmo.Tests.Output;

public class Test_CSVTotal
{
	[Theory]
	[InlineData(52304.40)]
	[InlineData(152232.22)]
	public void CSVTotal_Valeurs(double total)
	{
		string csvTotal = ICSV.Total(total);

		Assert.Equal($"Coût total : {total}", csvTotal);
	}
}