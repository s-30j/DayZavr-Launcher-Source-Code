using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Imaging;
using Dinobenz.Wpf.MessageBox.View;
using FontAwesome.WPF;
using Launcher;

namespace SERVER;

public partial class Shopcars : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private string _003CPriceby_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CSET_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CCmd_003Ek__BackingField;

	internal Shopcars SHOPLOOTControll;

	internal Border Border2;

	internal Border Border2_Copy;

	internal ImageAwesome ImSH;

	internal Label LNameSet;

	internal Label LPrice;

	internal Label LTXTPRICE;

	internal Button BBuy;

	internal Border GTXTD;

	internal TextBlock TxtDescr;

	internal Label LPriceDiscount;

	internal Label LTXTPDISCOUNT;

	private string Priceby
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = -1532;
			short num2 = num;
			num = -1532;
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
				return _003CPriceby_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = 1;
			if (num != 0)
			{
			}
			num = -31836;
			short num2 = num;
			num = -31836;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			_003CPriceby_003Ek__BackingField = value;
		}
	}

	public string SET
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 6596;
			short num2 = num;
			num = 6596;
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
				return _003CSET_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -30112;
			short num2 = num;
			num = -30112;
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
			_003CSET_003Ek__BackingField = value;
		}
	}

	public string Cmd
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = -4475;
			short num2 = num;
			num = -4475;
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
				return _003CCmd_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -29848;
			short num2 = num;
			num = -29848;
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
			_003CCmd_003Ek__BackingField = value;
		}
	}

	public string TXTName
	{
		get
		{
			short num = 0;
			_ = num;
			num = 26205;
			short num2 = num;
			num = 26205;
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
				return LNameSet.Content.ToString();
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = 11922;
			short num2 = num;
			num = 11922;
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
			LNameSet.Content = value;
		}
	}

	public string TXTPrice
	{
		get
		{
			short num = 0;
			_ = num;
			num = 4328;
			short num2 = num;
			num = 4328;
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
				return LPrice.Content.ToString();
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = 1;
			if (num != 0)
			{
			}
			num = -20134;
			short num2 = num;
			num = -20134;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			LPrice.Content = value;
		}
	}

	public string TXTPriceDiscount
	{
		get
		{
			short num = 0;
			_ = num;
			num = -23082;
			short num2 = num;
			num = -23082;
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
				return LPriceDiscount.Content.ToString();
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = 14195;
			short num2 = num;
			num = 14195;
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
			LPriceDiscount.Content = value;
		}
	}

	public string TXTItems
	{
		get
		{
			short num = 0;
			_ = num;
			num = 7407;
			short num2 = num;
			num = 7407;
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
				return SET;
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = 12129;
			short num2 = num;
			num = 12129;
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
			SET = value;
		}
	}

	public string IMGSHOP
	{
		set
		{
			short num;
			try
			{
				num = -29230;
				short num2 = num;
				num = -29230;
				switch (num2 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					ImSH.Source = new BitmapImage(new Uri(value));
					break;
				}
			}
			catch
			{
				ImSH.Source = new BitmapImage(new Uri("pack://application:,,/Design/shop.png"));
			}
			num = 0;
			_ = num;
			num = 1;
			if (num == 0)
			{
			}
		}
	}

	public string TXTDescription
	{
		get
		{
			short num = 0;
			_ = num;
			num = 17611;
			short num2 = num;
			num = 17611;
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
				return TxtDescr.Text.ToString();
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = -2258;
			short num2 = num;
			num = -2258;
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
			TxtDescr.Text = value;
		}
	}

	public string TXTCmd
	{
		get
		{
			short num = 0;
			_ = num;
			num = -8578;
			short num2 = num;
			num = -8578;
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
				return Cmd;
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = 1;
			if (num != 0)
			{
			}
			num = 27143;
			short num2 = num;
			num = 27143;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			Cmd = value;
		}
	}

	public string TXTPriceby
	{
		get
		{
			short num = 0;
			_ = num;
			num = -28109;
			short num2 = num;
			num = -28109;
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
				return Priceby;
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = -8046;
			short num2 = num;
			num = -8046;
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
			Priceby = value;
		}
	}

	public Shopcars()
	{
		InitializeComponent();
	}

	private void eval_a(object A_0, MouseButtonEventArgs A_1)
	{
		short num = 0;
		int num2 = num;
		MainWindow mainWindow = default(MainWindow);
		MessageBoxResult messageBoxResult = default(MessageBoxResult);
		while (true)
		{
			switch (num2)
			{
			case 0:
				switch (0)
				{
				default:
					goto end_IL_001f;
				case 0:
					break;
				}
				goto default;
			default:
				mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
				{
					short num4 = 0;
					_ = num4;
					num4 = 4194;
					short num5 = num4;
					num4 = 4194;
					switch (num5 == num4)
					{
					default:
						num4 = 1;
						if (num4 != 0)
						{
						}
						num4 = 0;
						if (num4 != 0)
						{
						}
						return A_0 is MainWindow;
					}
				}) as MainWindow;
				MainWindow.PriceItem = LPrice.Content.ToString();
				MainWindow.Items = TXTItems;
				MainWindow.Items_Name = LNameSet.Content.ToString();
				MainWindow.CMDItem = TXTCmd;
				num = 7;
				num2 = num;
				break;
			case 4:
			case 5:
				num = 3;
				num2 = num;
				break;
			case 3:
				if (messageBoxResult == MessageBoxResult.Yes)
				{
					num = 1;
					num2 = num;
					break;
				}
				goto case 2;
			case 6:
				messageBoxResult = MessageBoxWindow.Show(this, "Вы уверены что хотите приобрести данный товар - " + MainWindow.Items_Name + "?", MainWindow.name_messege, MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
				num = 4;
				num2 = num;
				break;
			case 1:
				mainWindow.GOBUY();
				num = 1;
				if (num != 0)
				{
				}
				num = 2;
				num2 = num;
				break;
			case 7:
				if (MainWindow.Langve == "RU")
				{
					num = 6;
					num2 = num;
					break;
				}
				messageBoxResult = MessageBoxWindow.Show(this, "Are you sure you want to purchase this product - " + MainWindow.Items_Name + "?", MainWindow.name_messege, MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
				num = 0;
				_ = num;
				num = 5;
				num2 = num;
				break;
			case 2:
				{
					num = -18134;
					short num3 = num;
					num = -18134;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						num = 0;
						if (num == 0)
						{
						}
						return;
					}
					goto case 1;
				}
				end_IL_001f:
				break;
			}
		}
	}
}
