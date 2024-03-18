namespace CredImmo.Tests;

public class Test_CalculMensualite
{
	[Fact]
	public void CalculMensualite_CasSimpleValide()
	{
		ushort montant = 50000;
		ushort duree = 108;
		double taux = 1;

		double mensualité = ICalculateur.CalculMensualite(montant, duree, taux);

		Assert.Equal(484.30, mensualité);
	}

	[Theory]
	[InlineData(49999, 108, 1)]
	[InlineData(50000, 107, 1)]
	[InlineData(50000, 301, 1)]
	[InlineData(50000, 108, -1)]
	public void CalculMensualite_InvalidArgs(ushort montant, ushort duree, double taux)
	{
		Assert.Throws<ArgumentException>(() => ICalculateur.CalculMensualite(montant, duree, taux));
	}
}