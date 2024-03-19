public class CSV : IOutput
{
	public string Total(double total)
	{
		return $"Coût total : {total}";
	}
}