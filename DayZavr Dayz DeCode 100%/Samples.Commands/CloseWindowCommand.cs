using System.Windows.Input;

namespace Samples.Commands;

public class CloseWindowCommand : CommandBase<CloseWindowCommand>
{
	public override void Execute(object parameter)
	{
		short num = -7381;
		short num2 = num;
		num = -7381;
		switch (num2 == num)
		{
		}
		num = 0;
		_ = num;
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		GetTaskbarWindow(parameter).Close();
		CommandManager.InvalidateRequerySuggested();
	}

	public override bool CanExecute(object parameter)
	{
		short num = -32288;
		short num2 = num;
		num = -32288;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			num = 0;
			if (num != 0)
			{
			}
			num = 1;
			if (num != 0)
			{
			}
			return GetTaskbarWindow(parameter) != null;
		}
	}
}
