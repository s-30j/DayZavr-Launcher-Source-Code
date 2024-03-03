using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using Dinobenz.Wpf.MessageBox.ViewModel;
using Launcher;

namespace Dinobenz.Wpf.MessageBox.View;

public partial class MessageBoxWindow : Window, IComponentConnector
{
	[CompilerGenerated]
	private MessageBoxViewModel m_eval_a;

	internal Label eval_b;

	internal Image eval_c;

	internal TextBlock eval_d;

	internal Button e;

	internal Button eval_f;

	internal Button g;

	private bool eval_h;

	public MessageBoxViewModel ViewModel
	{
		[CompilerGenerated]
		get
		{
			short num = -19318;
			short num2 = num;
			num = -19318;
			switch (num2 == num)
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
				num = 0;
				_ = num;
				return this.m_eval_a;
			}
		}
		[CompilerGenerated]
		private set
		{
			short num = 18265;
			short num2 = num;
			num = 18265;
			switch (num2 == num)
			{
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			this.m_eval_a = value;
		}
	}

	public static MessageBoxResult Show(Control control, string messageBoxText)
	{
		short num = -27670;
		short num2 = num;
		num = -27670;
		switch (num2 == num)
		{
		default:
			num = 0;
			if (num != 0)
			{
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			return eval_a(control, messageBoxText, null, MessageBoxButton.OK, MessageBoxImage.None);
		}
	}

	public static MessageBoxResult Show(Control control, string messageBoxText, string caption)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 24994;
		short num2 = num;
		num = 24994;
		switch (num2 == num)
		{
		default:
			num = 0;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			return eval_a(control, messageBoxText, caption, MessageBoxButton.OK, MessageBoxImage.None);
		}
	}

	public static MessageBoxResult Show(Control control, string messageBoxText, string caption, MessageBoxButton button)
	{
		short num = -30599;
		short num2 = num;
		num = -30599;
		switch (num2 == num)
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
			num = 0;
			_ = num;
			return eval_a(control, messageBoxText, caption, button, MessageBoxImage.None);
		}
	}

	public static MessageBoxResult Show(Control control, string messageBoxText, string caption, MessageBoxButton button, MessageBoxImage icon)
	{
		short num = 6966;
		short num2 = num;
		num = 6966;
		switch (num2 == num)
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
			num = 0;
			_ = num;
			return eval_a(control, messageBoxText, caption, button, icon);
		}
	}

	private static MessageBoxResult eval_a(Control A_0, string A_1, string A_2, MessageBoxButton A_3, MessageBoxImage A_4)
	{
		MessageBoxResult result = default(MessageBoxResult);
		short num2;
		try
		{
			int num = default(int);
			bool? flag = default(bool?);
			MessageBoxViewModel messageBoxViewModel = default(MessageBoxViewModel);
			switch (0)
			{
			default:
				while (true)
				{
					switch (num)
					{
					case 4:
						if (flag.HasValue)
						{
							num2 = 2;
							num = num2;
							continue;
						}
						goto IL_00fa;
					case 2:
						num2 = 3;
						num = num2;
						continue;
					case 3:
						if (flag.Value)
						{
							num2 = 5;
							num = num2;
							continue;
						}
						goto IL_00fa;
					case 5:
						result = messageBoxViewModel.Result;
						num2 = 0;
						num = num2;
						continue;
					case 0:
						goto end_IL_000a;
					case 1:
						goto IL_0117;
						IL_00fa:
						num2 = 1;
						num = num2;
						continue;
					}
					goto case 0;
					continue;
					end_IL_000a:
					break;
				}
				break;
			case 0:
				messageBoxViewModel = new MessageBoxViewModel
				{
					MessageText = A_1,
					Caption = A_2,
					Button = A_3,
					Icon = A_4
				};
				flag = new MessageBoxWindow(messageBoxViewModel)
				{
					Owner = Window.GetWindow(A_0)
				}.ShowDialog();
				num2 = 4;
				num = num2;
				goto default;
			}
		}
		catch
		{
			goto IL_0117;
		}
		goto IL_01b3;
		IL_0117:
		num2 = 1;
		if (num2 != 0)
		{
		}
		num2 = -31033;
		short num3 = num2;
		num2 = -31033;
		switch (num3 == num2)
		{
		default:
			num2 = 0;
			if (num2 != 0)
			{
			}
			num2 = 0;
			_ = num2;
			return MessageBoxResult.None;
		case false:
		case true:
			break;
		}
		goto IL_01b3;
		IL_01b3:
		return result;
	}

	private MessageBoxWindow(MessageBoxViewModel A_0)
	{
		ViewModel = A_0;
		base.DataContext = ViewModel;
		InitializeComponent();
		eval_a();
	}

	private void eval_c(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 20258;
		short num2 = num;
		num = 20258;
		switch (num2 == num)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		num = 0;
		_ = num;
		ViewModel.Result = MessageBoxResult.OK;
		base.DialogResult = true;
	}

	private void eval_b(object A_0, RoutedEventArgs A_1)
	{
		short num = -16329;
		short num2 = num;
		num = -16329;
		switch (num2 == num)
		{
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		num = 0;
		_ = num;
		ViewModel.Result = MessageBoxResult.Yes;
		base.DialogResult = true;
	}

	private void eval_a(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = -26042;
		short num2 = num;
		num = -26042;
		switch (num2 == num)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		num = 0;
		_ = num;
		ViewModel.Result = MessageBoxResult.Cancel;
		base.DialogResult = true;
	}

	private void eval_a()
	{
		int num = default(int);
		switch (0)
		{
		default:
		{
			MessageBoxButton button = default(MessageBoxButton);
			while (true)
			{
				short num2;
				switch (num)
				{
				case 8:
					if (MainWindow.Langve == "RU")
					{
						num2 = 3;
						num = num2;
						continue;
					}
					e.Content = "OK";
					eval_f.Content = "Yes";
					g.Content = "No";
					num2 = 7;
					num = num2;
					continue;
				case 3:
					num2 = 0;
					_ = num2;
					e.Content = "ОК";
					eval_f.Content = "Да";
					g.Content = "Нет";
					num2 = 9;
					num = num2;
					continue;
				case 5:
				case 6:
					num2 = 4;
					num = num2;
					continue;
				case 4:
					this.eval_c.Visibility = ((ViewModel.Icon != MessageBoxImage.Exclamation) ? Visibility.Collapsed : Visibility.Visible);
					return;
				case 2:
					goto IL_01f9;
				case 0:
					num2 = 2;
					num = num2;
					continue;
				case 7:
				case 9:
					button = ViewModel.Button;
					num2 = 1;
					num = num2;
					continue;
				case 1:
					{
						num2 = 27664;
						short num3 = num2;
						num2 = 27664;
						switch (num3 == num2)
						{
						case false:
						case true:
							break;
						default:
							goto IL_029b;
						}
						goto case 3;
					}
					IL_029b:
					num2 = 0;
					if (num2 != 0)
					{
					}
					switch (button)
					{
					case MessageBoxButton.OKCancel:
					case MessageBoxButton.YesNoCancel:
						break;
					case MessageBoxButton.YesNo:
						goto IL_00ff;
					case MessageBoxButton.OK:
					case (MessageBoxButton)2:
						goto IL_01f9;
					default:
						goto IL_02ca;
					}
					goto case 5;
					IL_02ca:
					num2 = 0;
					num = num2;
					continue;
					IL_00ff:
					num2 = 1;
					if (num2 != 0)
					{
					}
					eval_f.Visibility = Visibility.Visible;
					g.Visibility = Visibility.Visible;
					num2 = 6;
					num = num2;
					continue;
					IL_01f9:
					e.Visibility = Visibility.Visible;
					num2 = 5;
					num = num2;
					continue;
				}
				break;
			}
			goto case 0;
		}
		case 0:
		{
			e.Visibility = Visibility.Collapsed;
			eval_f.Visibility = Visibility.Collapsed;
			g.Visibility = Visibility.Collapsed;
			short num2 = 8;
			num = num2;
			goto default;
		}
		}
	}

	private void eval_a(object A_0, MouseButtonEventArgs A_1)
	{
		short num = 5099;
		short num2 = num;
		num = 5099;
		switch (num2 == num)
		{
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		num = 0;
		_ = num;
		DragMove();
	}
}
