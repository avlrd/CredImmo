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

public abstract class CredImmo
{
	public static double CalculMensualité(ushort montant, ushort duree, double taux)
	{
		double mensualite = Math.Round(montant*taux/100/12/(1-Math.Pow(1+taux/100/12, -duree)), 2);
		return mensualite;
	}
}