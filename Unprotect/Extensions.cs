namespace Unprotect;

public static class Extensions
{
	public static T WriteTo<T>(this T obj, TextWriter output)
	{
		output.WriteLine(obj);
		return obj;
	}

	public static object WriteTo(this object obj, TextWriter output)
	{
		output.WriteLine((string) obj);
		return obj;
	}
}