namespace CredImmo.Tests.Calculateur;

public class Test_CalculTotal
{
	[Fact]
	public void CalculTotal_CasSimpleValide()
	{
		uint montant = 50000;
		ushort duree = 108;
		double taux = 1;

		double total = ICalculateur.CalculTotal(montant, duree, taux);

		Assert.Equal(52304.40, total);
	}

	[Fact]
	public void CalculTotal_MaxValues()
	{
		uint montant = uint.MaxValue;
		ushort duree = 300;
		double taux = 100;

		Assert.True(ICalculateur.CalculTotal(montant, duree, taux) < double.MaxValue);
	}
}