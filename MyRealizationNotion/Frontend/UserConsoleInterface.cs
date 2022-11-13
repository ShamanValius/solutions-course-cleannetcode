namespace MyRealizationNotion;
static public class UserConsoleInterface
{
	static public void PrintMenu(Dictionary<string, IOperation> menu)
	{
		Console.WriteLine("Доступные операции:");
		foreach (var item in menu)
		{
			Console.WriteLine($"- {item.Key}");
		}
	}

	static public void PrintMessage(string message)
	{
		Console.WriteLine(message);
	}

	static public string InputMessage()
	{
		string? str = null;
		while (str == null)
		{
			PrintMessage("Введите команду!");
			str = Console.ReadLine();
		}
		return str;
	}
}