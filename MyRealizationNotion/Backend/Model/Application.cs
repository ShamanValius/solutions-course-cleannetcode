namespace MyRealizationNotion;

public class Application
{
	private readonly Dictionary<string, IOperation> menu;

	public Application()
	{
		this.menu = new Dictionary<string, IOperation>{
			{"create", new CreateNewNotionOperation()},
			{"get", new GetNotionOperation()}
		};
	}

	public void Run(CancellationToken token)
	{
		while (!token.IsCancellationRequested)
		{
			UserConsoleInterface.PrintMenu(menu);

			string operationName = UserConsoleInterface.InputMessage();

			if (!menu.TryGetValue(operationName, out var operation))
			{
				UserConsoleInterface.PrintMessage($"Команды {operationName} не существует!");
				continue;
			}

			operation.Invoke();
		}
	}
}
