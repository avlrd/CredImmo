namespace CredImmo.Tests;

public class Test_Validation
{
	[Theory]
	[InlineData("300000", "240", "4.3", ".")]
	[InlineData("120000", "120", "0.0", ".")]
	public void Test_VerificationArguments_Success(string arg1, string arg2, string arg3, string arg4)
	{
		Assert.True(IArgsValidation.ValidationArguments(new string[] { arg1, arg2, arg3, arg4 }));
	}

	[Theory]
	[InlineData("10000", "108", "1.0", ".")]
	[InlineData("50000", "301", "0.01", ".")]
	[InlineData("50000", "107", "1.0", ".")]
	[InlineData("50000", "108", "-1.0", ".")]
	public void Test_VerificationArguments_Fail(string arg1, string arg2, string arg3, string arg4)
	{
		Assert.False(IArgsValidation.ValidationArguments(new string[] { arg1, arg2, arg3, arg4 }));
	}
}