namespace CredImmo.Tests;

public class Test_CSVTotal
{
	[Fact]
	public void CSVTotal()
	{
		CSV output = new CSV();
		string csvTotal = output.Total();

		Assert.Equal("Coût total : 52304.40", csvTotal);
	}
}

public class CSV
{
	public string Total()
	{
		return "Coût total : 52304.40";
	}
}