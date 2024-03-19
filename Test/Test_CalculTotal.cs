namespace CredImmo.Tests;

public class Test_CalculTotal
{
	public void CalculTotal_CasSimpleValide()
	{
		ushort montant = 50000;
		ushort duree = 108;
		double taux = 1;

		double total = ICalculateur.CalculTotal(montant, duree, taux);

		Assert.Equal(52284.40, total);
	}
}