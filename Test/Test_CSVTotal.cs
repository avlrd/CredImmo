namespace CredImmo.Tests;

public class Test_CSVTotal
{
	[Theory]
	[InlineData(52304.40)]
	[InlineData(152232.22)]
	public void CSVTotal(double total)
	{
		CSV output = new CSV();
		string csvTotal = output.Total(total);

		Assert.Equal($"Coût total : {total}", csvTotal);
	}
}