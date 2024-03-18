namespace CredImmo;

public abstract class CredImmo
{
	public static double CalculMensualite(ushort montant, ushort duree, double taux)
	{
		double mensualite = Math.Round(montant*taux/100/12/(1-Math.Pow(1+taux/100/12, -duree)), 2);
		return mensualite;
	}
}