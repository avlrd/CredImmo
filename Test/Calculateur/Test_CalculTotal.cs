namespace CredImmo.Tests.Calculateur;

public class Test_CalculTotal
{
	[Fact]
	public void CalculTotal_CasSimpleValide()
	{
		ushort montant = 50000;
		ushort duree = 108;
		double taux = 1;

		double total = ICalculateur.CalculTotal(montant, duree, taux);

		Assert.Equal(52304.40, total);
	}
}