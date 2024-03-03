using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using Hardcodet.Wpf.TaskbarNotification;

namespace Samples.Commands;

public abstract class CommandBase<T> : MarkupExtension, ICommand where T : class, ICommand, new()
{
	private static T eval_a;

	public static bool IsDesignMode
	{
		get
		{
			short num = -21539;
			short num2 = num;
			num = -21539;
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
				return (bool)DependencyPropertyDescriptor.FromProperty(DesignerProperties.IsInDesignModeProperty, typeof(FrameworkElement)).Metadata.DefaultValue;
			}
		}
	}

	public event EventHandler CanExecuteChanged
	{
		add
		{
			short num = 15735;
			short num2 = num;
			num = 15735;
			switch (num2 == num)
			{
			}
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
			CommandManager.RequerySuggested += value;
		}
		remove
		{
			short num = 26352;
			short num2 = num;
			num = 26352;
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
			CommandManager.RequerySuggested -= value;
		}
	}

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 2;
		int num2 = num;
		while (true)
		{
			num = 10124;
			short num3 = num;
			num = 10124;
			switch (num3 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 2:
					switch (0)
					{
					default:
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					if (eval_a == null)
					{
						break;
					}
					goto case 1;
				case 0:
					num = 0;
					_ = num;
					eval_a = new T();
					num = 1;
					num2 = num;
					continue;
				case 1:
					return eval_a;
				}
				break;
			case false:
			case true:
				break;
			}
			num = 0;
			num2 = num;
		}
	}

	public abstract void Execute(object parameter);

	public virtual bool CanExecute(object parameter)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 37;
		short num2 = num;
		num = 37;
		switch (num2 == num)
		{
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
		return !IsDesignMode;
	}

	protected Window GetTaskbarWindow(object commandParameter)
	{
		short num = 0;
		int num2 = num;
		TaskbarIcon taskbarIcon = default(TaskbarIcon);
		while (true)
		{
			switch (num2)
			{
			case 0:
				switch (0)
				{
				default:
					continue;
				case 0:
					break;
				}
				goto default;
			default:
				if (IsDesignMode)
				{
					num = 2;
					num2 = num;
				}
				else
				{
					taskbarIcon = commandParameter as TaskbarIcon;
					num = 1;
					num2 = num;
				}
				continue;
			case 2:
			{
				num = -28713;
				short num3 = num;
				num = -28713;
				switch (num3 == num)
				{
				default:
					num = 0;
					_ = num;
					goto case true;
				case true:
					num = 0;
					if (num != 0)
					{
					}
					num = 1;
					if (num != 0)
					{
					}
					return null;
				case false:
				case true:
					break;
				}
				break;
			}
			case 3:
				return TryFindParent<Window>(taskbarIcon);
			case 1:
				break;
			}
			if (taskbarIcon == null)
			{
				break;
			}
			num = 3;
			num2 = num;
		}
		return null;
	}

	public static TParent TryFindParent<TParent>(DependencyObject child) where TParent : DependencyObject
	{
		switch (0)
		{
		case 0:
			goto IL_0020;
		}
		goto IL_000a;
		IL_000a:
		int num = default(int);
		DependencyObject parentObject = default(DependencyObject);
		TParent val = default(TParent);
		short num2;
		while (true)
		{
			switch (num)
			{
			case 0:
				if (parentObject == null)
				{
					num2 = 2;
					num = num2;
					continue;
				}
				goto IL_005b;
			case 1:
				if (val != null)
				{
					num2 = 3;
					num = num2;
					continue;
				}
				return TryFindParent<TParent>(parentObject);
			case 3:
			{
				num2 = 10932;
				short num3 = num2;
				num2 = 10932;
				switch (num3 == num2)
				{
				case false:
				case true:
					break;
				default:
					num2 = 1;
					if (num2 != 0)
					{
					}
					num2 = 0;
					if (num2 != 0)
					{
					}
					num2 = 0;
					_ = num2;
					return val;
				}
				goto IL_005b;
			}
			case 2:
				{
					return null;
				}
				IL_005b:
				val = parentObject as TParent;
				num2 = 1;
				num = num2;
				continue;
			}
			break;
		}
		goto IL_0020;
		IL_0020:
		parentObject = GetParentObject(child);
		num2 = 0;
		num = num2;
		goto IL_000a;
	}

	public static DependencyObject GetParentObject(DependencyObject child)
	{
		short num = 2;
		int num2 = num;
		ContentElement contentElement = default(ContentElement);
		DependencyObject parent = default(DependencyObject);
		while (true)
		{
			switch (num2)
			{
			case 2:
				switch (0)
				{
				default:
					goto end_IL_0021;
				case 0:
					break;
				}
				goto default;
			default:
				if (child == null)
				{
					num = 0;
					num2 = num;
				}
				else
				{
					contentElement = child as ContentElement;
					num = 3;
					num2 = num;
				}
				break;
			case 5:
				return (contentElement as FrameworkContentElement)?.Parent;
			case 6:
				return parent;
			case 3:
			{
				num = 21585;
				short num3 = num;
				num = 21585;
				switch (num3 == num)
				{
				case false:
				case true:
					break;
				default:
					num = 0;
					_ = num;
					goto case true;
				case true:
					num = 0;
					if (num != 0)
					{
					}
					if (contentElement != null)
					{
						num = 1;
						num2 = num;
						goto end_IL_0021;
					}
					return VisualTreeHelper.GetParent(child);
				}
				goto case 6;
			}
			case 0:
				return null;
			case 1:
				parent = ContentOperations.GetParent(contentElement);
				num = 4;
				num2 = num;
				break;
			case 4:
				{
					if (parent == null)
					{
						num = 1;
						if (num != 0)
						{
						}
						num = 5;
						num2 = num;
					}
					else
					{
						num = 6;
						num2 = num;
					}
					break;
				}
				end_IL_0021:
				break;
			}
		}
	}
}
