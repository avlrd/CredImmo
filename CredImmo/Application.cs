namespace CredImmo;

public class Application
{
	static void Main(string[] args)
	{
		if(!IArgsValidation.ValidationArguments(args))
			return;
		Console.WriteLine("Hello :)");
	}
}