namespace CredImmo.Tests.Calculateur;

public class Test_CalculMensualite
{
	[Fact]
	public void CalculMensualite_CasSimpleValide()
	{
		uint montant = 50000;
		ushort duree = 108;
		double taux = 1;

		double mensualité = ICalculateur.CalculMensualite(montant, duree, taux);

		Assert.Equal(484.30, mensualité);
	}

	[Fact]
	public void CalculMensualite_MaxValues()
	{
		uint montant = uint.MaxValue;
		ushort duree = 300;
		double taux = 100;

		Assert.True(ICalculateur.CalculMensualite(montant, duree, taux) < double.MaxValue);
	}

	[Theory]
	[InlineData(49999, 108, 1)]
	[InlineData(50000, 107, 1)]
	[InlineData(50000, 301, 1)]
	[InlineData(50000, 108, -1)]
	[InlineData(50000, 108, 100.01)]
	public void CalculMensualite_InvalidArgs(uint montant, ushort duree, double taux)
	{
		Assert.Throws<ArgumentException>(() => ICalculateur.CalculMensualite(montant, duree, taux));
	}
}