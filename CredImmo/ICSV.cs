public interface ICSV
{
	public static string Total(double total)
	{
		return $"Coût total : {total}";
	}

	public static string Mensualite(int numero, double rembourse, double restant)
	{
		return $"{numero},{rembourse},{restant}";
	}

	public static string Labels()
	{
		return "Numéro de mensualité,Capital remboursé,Restant dû";
	}
}