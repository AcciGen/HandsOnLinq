namespace HandsOnLinq
{
	public class Program
	{
		private static void Main(string[] args)
		{
			char c = 'a';
			List<string> stringList = ["arcanera", "a", "armora", "arkane"];

			var result = Tasks.Task1(c, stringList);
			foreach(string res in result)
			{
				Console.WriteLine(res);
			}
		}
	}
}