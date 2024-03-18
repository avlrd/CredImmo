using CredImmo;

namespace CredImmo.Tests;

public class Test
{
	[Fact]
	public void CalculMensualité_CasSimpleValide()
	{
		ushort montant = 50000;
		ushort duree = 108;
		double taux = 1;

		double mensualité = CredImmo.CalculMensualité(montant, duree, taux);

		Assert.Equal(484.30, mensualité);
	}
}