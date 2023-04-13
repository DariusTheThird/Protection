if (args.Length != 1)
{
	Error.WriteLine($"expected exactly 1 argument. received: {args.Length}");
	return -1;
}

try
{
	new ProtectionServiceBuilder()
	   .Build()
	   .Unprotect(args.Single())
	   .WriteTo(Out);

	return 0;
}
catch (Exception e)
{
	Error.WriteLine($"{e.GetType()} caught: {e.Message}");
	return -10;
}
