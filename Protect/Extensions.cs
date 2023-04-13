namespace Protect;

public static class Extensions
{
	public static T WriteTo<T>(this T obj, TextWriter output)
	{
		output.WriteLine(obj);
		return obj;
	}
}