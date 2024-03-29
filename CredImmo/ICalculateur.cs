namespace CredImmo;

public interface ICalculateur
{
	public static double CalculMensualite(uint montant, ushort duree, double taux)
	{
		if(montant < 50000)
			throw new ArgumentException("Montant inférieur à 50 000");
		if(duree < 108)
			throw new ArgumentException("Durée inférieure à 9 ans (108 mois)");
		if(duree > 300)
			throw new ArgumentException("Durée supérieure à 25 ans (300 mois)");
		if(taux < 0)
			throw new ArgumentException("Taux négatif");
		if(taux > 100)
			throw new ArgumentException("Taux supérieur à 100%");

		double mensualite = Math.Round(montant*taux/100/12/(1-Math.Pow(1+taux/100/12, -duree)), 2);
		return mensualite;
	}

	public static double CalculTotal(uint montant, ushort duree, double taux)
	{
		double mensualite = CalculMensualite(montant, duree, taux);
		double total = mensualite * duree;
		return total;
	}
}