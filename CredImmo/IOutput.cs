public interface IOutput
{
	public abstract string Total(double total);
	public abstract string Mensualite(int numero, double rembourse, double restant);
}