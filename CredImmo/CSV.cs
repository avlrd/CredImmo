public class CSV : IOutput
{
	public string Total(double total)
	{
		return $"Coût total : {total}";
	}

	public string Mensualite(int numero, double rembourse, double restant)
	{
		return $"{numero},{rembourse},{restant}";
	}
}