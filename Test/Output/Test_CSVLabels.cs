namespace CredImmo.Tests.Output;

public class Test_CSVLabels
{
	[Fact]
	public void CSVLabels()
	{
		Assert.Equal("Numéro de mensualité,Capital remboursé,Restant dû", ICSV.Labels());
	}
}