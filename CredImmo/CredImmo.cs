namespace CredImmo;

public abstract class CredImmo
{
	public static double CalculMensualite(ushort montant, ushort duree, double taux)
	{
		if(montant < 50000)
			throw new ArgumentException("Montant inférieur à 50 000");
		if(duree < 108)
			throw new ArgumentException("Durée inférieure à 9 ans (108 mois)");
		if(duree > 300)
			throw new ArgumentException("Durée supérieure à 25 ans (300 mois)");
		if(taux < 0)
			throw new ArgumentException("Taux négatif");

		double mensualite = Math.Round(montant*taux/100/12/(1-Math.Pow(1+taux/100/12, -duree)), 2);
		return mensualite;
	}
}