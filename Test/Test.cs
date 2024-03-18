using CredImmo;

namespace CredImmo.Tests;

public class Test
{
	[Fact]
	public void CalculMensualite_CasSimpleValide()
	{
		ushort montant = 50000;
		ushort duree = 108;
		double taux = 1;

		double mensualité = CredImmo.CalculMensualite(montant, duree, taux);

		Assert.Equal(484.30, mensualité);
	}

	[Theory]
	[InlineData(49999, 107, 1)]
	[InlineData(50000, 301, 1)]
	[InlineData(50000, 108, -1)]
	public void CalculMensualite_(ushort montant, ushort duree, double taux)
	{
		Assert.Throws<ArgumentException>(() => CredImmo.CalculMensualite(montant, duree, taux));
	}
}