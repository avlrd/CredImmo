namespace CredImmo.Tests;

public class Test_CSVLabels
{
	[Fact]
	public void CSVLabels()
	{
		Assert.Equal("Numéro,Remboursé, Restant", ICSV.Labels());
	}
}