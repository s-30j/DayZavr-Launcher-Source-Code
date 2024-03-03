using System.Windows;
using System.Windows.Controls;

namespace ChatBubbles;

public class GridUtils
{
	public static readonly DependencyProperty RowDefinitionsProperty;

	public static readonly DependencyProperty ColumnDefinitionsProperty;

	public static string GetRowDefinitions(DependencyObject d)
	{
		short num = 19491;
		short num2 = num;
		num = 19491;
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
			return (string)d.GetValue(RowDefinitionsProperty);
		}
	}

	public static void SetRowDefinitions(DependencyObject d, string value)
	{
		short num = 10780;
		short num2 = num;
		num = 10780;
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
		d.SetValue(RowDefinitionsProperty, value);
	}

	private static void eval_b(DependencyObject A_0, DependencyPropertyChangedEventArgs A_1)
	{
		short num = 0;
		int num2 = num;
		switch (num2)
		{
		default:
		{
			int num3 = default(int);
			Grid grid = default(Grid);
			string[] array = default(string[]);
			switch (0)
			{
			default:
			{
				string text = default(string);
				while (true)
				{
					switch (num2)
					{
					case 6:
					{
						num = -2149;
						short num4 = num;
						num = -2149;
						switch (num4 == num)
						{
						default:
							num = 0;
							if (num == 0)
							{
							}
							break;
						case false:
						case true:
							break;
						}
						goto case 7;
					}
					case 0:
					case 1:
						num3++;
						num = 7;
						num2 = num;
						continue;
					case 4:
						if (!(text.Trim() == ""))
						{
							num = 1;
							if (num != 0)
							{
							}
							grid.RowDefinitions.Add(new RowDefinition
							{
								Height = eval_a(text)
							});
							num = 0;
							num2 = num;
						}
						else
						{
							num = 2;
							num2 = num;
						}
						continue;
					case 7:
						num = 3;
						num2 = num;
						continue;
					case 3:
						if (num3 < array.Length)
						{
							text = array[num3];
							num = 4;
							num2 = num;
						}
						else
						{
							num = 0;
							_ = num;
							num = 5;
							num2 = num;
						}
						continue;
					case 5:
						return;
					case 2:
						grid.RowDefinitions.Add(new RowDefinition());
						num = 1;
						num2 = num;
						continue;
					}
					break;
				}
				goto case 0;
			}
			case 0:
				grid = A_0 as Grid;
				grid.RowDefinitions.Clear();
				array = (A_1.NewValue as string).Split(',');
				num3 = 0;
				num = 6;
				num2 = num;
				goto default;
			}
		}
		}
	}

	public static string GetColumnDefinitions(DependencyObject d)
	{
		short num = 11016;
		short num2 = num;
		num = 11016;
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
			return (string)d.GetValue(ColumnDefinitionsProperty);
		}
	}

	public static void SetColumnDefinitions(DependencyObject d, string value)
	{
		short num = -22490;
		short num2 = num;
		num = -22490;
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
		d.SetValue(ColumnDefinitionsProperty, value);
	}

	private static void eval_a(DependencyObject A_0, DependencyPropertyChangedEventArgs A_1)
	{
		short num = 0;
		int num2 = num;
		switch (num2)
		{
		default:
		{
			int num3 = default(int);
			Grid grid = default(Grid);
			string[] array = default(string[]);
			switch (0)
			{
			default:
			{
				string text = default(string);
				while (true)
				{
					switch (num2)
					{
					case 6:
					{
						num = -25171;
						short num4 = num;
						num = -25171;
						switch (num4 == num)
						{
						default:
							num = 0;
							if (num == 0)
							{
							}
							break;
						case false:
						case true:
							break;
						}
						goto case 7;
					}
					case 0:
					case 1:
						num3++;
						num = 7;
						num2 = num;
						continue;
					case 4:
						if (!(text.Trim() == ""))
						{
							grid.ColumnDefinitions.Add(new ColumnDefinition
							{
								Width = eval_a(text)
							});
							num = 1;
							if (num != 0)
							{
							}
							num = 0;
							num2 = num;
						}
						else
						{
							num = 2;
							num2 = num;
						}
						continue;
					case 7:
						num = 3;
						num2 = num;
						continue;
					case 3:
						if (num3 < array.Length)
						{
							text = array[num3];
							num = 4;
							num2 = num;
						}
						else
						{
							num = 0;
							_ = num;
							num = 5;
							num2 = num;
						}
						continue;
					case 5:
						return;
					case 2:
						grid.ColumnDefinitions.Add(new ColumnDefinition());
						num = 1;
						num2 = num;
						continue;
					}
					break;
				}
				goto case 0;
			}
			case 0:
				grid = A_0 as Grid;
				grid.ColumnDefinitions.Clear();
				array = (A_1.NewValue as string).Split(',');
				num3 = 0;
				num = 6;
				num2 = num;
				goto default;
			}
		}
		}
	}

	private static GridLength eval_a(string A_0)
	{
		switch (0)
		{
		case 0:
			goto IL_002c;
		}
		goto IL_000a;
		IL_000a:
		int num = default(int);
		short num2;
		while (true)
		{
			switch (num)
			{
			case 5:
				if (A_0.ToLowerInvariant().Equals("auto"))
				{
					num2 = 6;
					num = num2;
				}
				else
				{
					num2 = 4;
					num = num2;
				}
				continue;
			case 0:
				A_0 = A_0.Replace("*", "");
				num2 = 1;
				num = num2;
				continue;
			case 1:
				num2 = 0;
				_ = num2;
				if (string.IsNullOrEmpty(A_0))
				{
					num2 = 2;
					num = num2;
					continue;
				}
				goto case 3;
			case 2:
			{
				num2 = 23467;
				short num3 = num2;
				num2 = 23467;
				switch (num3 == num2)
				{
				default:
					num2 = 1;
					if (num2 != 0)
					{
					}
					num2 = 0;
					if (num2 != 0)
					{
					}
					A_0 = "1";
					num2 = 3;
					num = num2;
					continue;
				case false:
				case true:
					break;
				}
				goto case 6;
			}
			case 6:
				return new GridLength(0.0, GridUnitType.Auto);
			case 3:
				return new GridLength(double.Parse(A_0), GridUnitType.Star);
			case 4:
				if (A_0.Contains("*"))
				{
					num2 = 0;
					num = num2;
					continue;
				}
				return new GridLength(double.Parse(A_0), GridUnitType.Pixel);
			}
			break;
		}
		goto IL_002c;
		IL_002c:
		A_0 = A_0.Trim();
		num2 = 5;
		num = num2;
		goto IL_000a;
	}

	static GridUtils()
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 31042;
		short num2 = num;
		num = 31042;
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
		RowDefinitionsProperty = DependencyProperty.RegisterAttached("RowDefinitions", typeof(string), typeof(GridUtils), new PropertyMetadata("", eval_b));
		ColumnDefinitionsProperty = DependencyProperty.RegisterAttached("ColumnDefinitions", typeof(string), typeof(GridUtils), new PropertyMetadata("", eval_a));
	}
}
