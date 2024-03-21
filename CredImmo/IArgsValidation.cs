namespace CredImmo;

public interface IArgsValidation
{
	public static bool ValidationArguments(string[] args)
	{
		if(args.Length != 4)
		{
			Console.WriteLine("Utilisation : CredImmo <montant> <duree> <taux> <destination fichier csv>");
			return false;
		}

		if(!uint.TryParse(args[0], out uint arg1))
		{
			Console.WriteLine($"Erreur : Analyse du paramètre 'montant' echouée (Reçu : {arg1})");
			return false;
		}

		if(!ushort.TryParse(args[1], out ushort arg2))
		{
			Console.WriteLine($"Erreur : Analyse du paramètre 'durée' echouée (Reçu : {arg2})");
			return false;
		}

		if(!double.TryParse(args[2], out double arg3))
		{
			Console.WriteLine($"Erreur : Analyse du paramètre 'taux' echouée (Reçu : {arg3})");
			return false;
		}

		return true;
	}
}