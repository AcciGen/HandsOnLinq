namespace HandsOnLinq
{
	public class Program
	{
		private static void Main(string[] args)
		{
			List<string> stringList = ["arcanera", "a", "armora", "arkane"];
			char c = 'a';

			var task1Result = Tasks.Task1(c, stringList);
			Console.WriteLine("Task 1");
			foreach(string res in task1Result)
			{
				Console.WriteLine(res);
			}

			var task3Result = Tasks.Task3(stringList);
			Console.WriteLine("\nTask 3");
			foreach (string res in task3Result)
            {
                Console.WriteLine(res);
            }

			int k = 4;
			stringList = ["A2K4", "ARK35", "DA4K"];

        }
	}
}