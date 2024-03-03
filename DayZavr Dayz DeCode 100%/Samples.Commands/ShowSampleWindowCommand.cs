using System.Windows;
using System.Windows.Input;

namespace Samples.Commands;

public class ShowSampleWindowCommand : CommandBase<ShowSampleWindowCommand>
{
	public override void Execute(object parameter)
	{
		short num = 0;
		_ = num;
		num = -15865;
		short num2 = num;
		num = -15865;
		switch (num2 == num)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		num = 1;
		if (num != 0)
		{
		}
		GetTaskbarWindow(parameter).Show();
		CommandManager.InvalidateRequerySuggested();
	}

	public override bool CanExecute(object parameter)
	{
		short num = 18940;
		short num2 = num;
		num = 18940;
		Window taskbarWindow = default(Window);
		switch (num2 == num)
		{
		default:
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
			taskbarWindow = GetTaskbarWindow(parameter);
			if (taskbarWindow != null)
			{
				goto case false;
			}
			return false;
		case false:
		case true:
			return !taskbarWindow.IsVisible;
		}
	}
}
