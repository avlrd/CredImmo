namespace CredImmo.Tests;

public class Test_Validation
{
	[Theory]
	[InlineData("300000", "240", "4.3", ".")]
	[InlineData("120000", "120", "0.0", ".")]
	public void Test_VerificationArguments_Success(string arg1, string arg2, string arg3, string arg4)
	{
		Assert.True(IArgsValidation.ValidationArguments([arg1, arg2, arg3, arg4]));
	}

	[Theory]
	[InlineData("10000", "108", "1.0", ".")]
	[InlineData("50000", "301", "0.01", ".")]
	[InlineData("50000", "107", "1.0", ".")]
	[InlineData("50000", "108", "-1.0", ".")]
	public void Test_VerificationArguments_Fail(string arg1, string arg2, string arg3, string arg4)
	{
		Assert.False(IArgsValidation.ValidationArguments([arg1, arg2, arg3, arg4]));
	}
}

public interface IArgsValidation
{
	public static bool ValidationArguments(string[] args)
	{
		if(args.Length != 4)
		{
			Console.WriteLine("Utilisation : CredImmo <montant> <duree> <taux> <destination fichier csv>");
			return false;
		}

		if(!uint.TryParse(args[0], out uint arg1) || arg1 < 50000)
		{
			Console.WriteLine($"Erreur : Le montant doit être un nombre entier supérieur ou égal à 50000. (Obtenu : {arg1})");
			return false;
		}

		if(!ushort.TryParse(args[1], out ushort arg2) || arg2 < 108 || arg2 > 300)
		{
			Console.WriteLine($"Erreur : La durée doit être un nombre entier compris entre 108 et 300. (Obtenu : {arg2})");
			return false;
		}

		if(!double.TryParse(args[2], out double arg3) || arg3 < 0.0)
		{
			Console.WriteLine($"Erreur : Le taux doit être un nombre décimal supérieur ou égal à 0. (Obtenu : {arg3})");
			return false;
		}

		return true;
	}
}