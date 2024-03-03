using System.Windows;
using System.Windows.Markup;

namespace TheRThemes;

public partial class ColourfulDarkTheme : ResourceDictionary, IComponentConnector, IStyleConnector
{
	private bool m_eval_a;

	private void eval_c(object A_0, RoutedEventArgs A_1)
	{
		while (A_1.Source != null)
		{
			short num = -18595;
			short num2 = num;
			num = -18595;
			switch (num2 == num)
			{
			case false:
			case true:
				continue;
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
			try
			{
				CloseWind(Window.GetWindow((FrameworkElement)A_1.Source));
				return;
			}
			catch
			{
				return;
			}
		}
	}

	private void eval_b(object A_0, RoutedEventArgs A_1)
	{
		while (A_1.Source != null)
		{
			short num = 10653;
			short num2 = num;
			num = 10653;
			switch (num2 == num)
			{
			case false:
			case true:
				continue;
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
			try
			{
				MaximizeRestore(Window.GetWindow((FrameworkElement)A_1.Source));
				return;
			}
			catch
			{
				return;
			}
		}
	}

	private void eval_a(object A_0, RoutedEventArgs A_1)
	{
		while (A_1.Source != null)
		{
			short num = 15011;
			short num2 = num;
			num = 15011;
			switch (num2 == num)
			{
			case false:
			case true:
				continue;
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 0;
			if (num != 0)
			{
			}
			try
			{
				num = 1;
				if (num != 0)
				{
				}
				MinimizeWind(Window.GetWindow((FrameworkElement)A_1.Source));
				break;
			}
			catch
			{
				break;
			}
		}
	}

	public void CloseWind(Window window)
	{
		short num = -6431;
		short num2 = num;
		num = -6431;
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
		window.Close();
	}

	public void MaximizeRestore(Window window)
	{
		short num = 2;
		int num2 = num;
		while (true)
		{
			num = 0;
			_ = num;
			switch (num2)
			{
			case 2:
				switch (0)
				{
				default:
					goto end_IL_0049;
				case 0:
					break;
				}
				goto default;
			default:
				if (window.WindowState == WindowState.Maximized)
				{
					num = -1903;
					short num3 = num;
					num = -1903;
					switch (num3 == num)
					{
					default:
						num = 1;
						if (num != 0)
						{
						}
						num = 0;
						if (num != 0)
						{
						}
						num = 3;
						num2 = num;
						break;
					case false:
					case true:
						return;
					}
				}
				else
				{
					num = 4;
					num2 = num;
				}
				break;
			case 1:
				window.WindowState = WindowState.Maximized;
				num = 0;
				num2 = num;
				break;
			case 0:
				return;
			case 4:
				if (window.WindowState == WindowState.Normal)
				{
					num = 1;
					num2 = num;
					break;
				}
				return;
			case 3:
				{
					window.WindowState = WindowState.Normal;
					return;
				}
				end_IL_0049:
				break;
			}
		}
	}

	public void MinimizeWind(Window window)
	{
		short num = 18462;
		short num2 = num;
		num = 18462;
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
		window.WindowState = WindowState.Minimized;
	}
}
