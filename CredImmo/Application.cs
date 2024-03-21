using System.Text;

namespace CredImmo;

public class Application
{
	static void Main(string[] args)
	{
		if(!IArgsValidation.ValidationArguments(args))
			return;
			
		uint montant = uint.Parse(args[0]);
		ushort duree = ushort.Parse(args[1]);
		double taux = double.Parse(args[2]);
		string cheminDestination = args[3];
		
		double mensualite = ICalculateur.CalculMensualite(montant, duree, taux);
		double total = ICalculateur.CalculTotal(montant, duree, taux);

		using StreamWriter stream = new(cheminDestination, false, Encoding.UTF8);

		stream.WriteLine(ICSV.Total(total));
		stream.WriteLine(ICSV.Labels());
		for (int i = 1; i <= duree; i++)
		{
			double capitalRembourse = mensualite * i;
			double restantDu = total - capitalRembourse;
			stream.WriteLine(ICSV.Mensualite(i, capitalRembourse, restantDu));
		}

		Console.WriteLine("Fichier généré.");
	}
}