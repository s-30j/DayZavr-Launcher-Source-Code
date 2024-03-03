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

public partial class Shopset : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private string _003CPriceby_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CSET_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CCmd_003Ek__BackingField;

	internal Shopset SHOPLOOTControll;

	internal Border Border2;

	internal Grid GNAME;

	internal ImageAwesome ImSH;

	internal Label LNameSet;

	internal Border GTXTD;

	internal TextBlock TxtDescr;

	internal Label LPrice;

	internal Label LTXTPRICE;

	internal Label LPriceDiscount;

	internal Label LTXTPDISCOUNT;

	internal Button BBuy;

	private string Priceby
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 148;
			short num2 = num;
			num = 148;
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
				return _003CPriceby_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = 16601;
			short num2 = num;
			num = 16601;
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
			num = 11505;
			short num2 = num;
			num = 11505;
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
			num = 11563;
			short num2 = num;
			num = 11563;
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
			num = 3850;
			short num2 = num;
			num = 3850;
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
				return _003CCmd_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -8669;
			short num2 = num;
			num = -8669;
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
			num = -13321;
			short num2 = num;
			num = -13321;
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
				return LNameSet.Content.ToString();
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = -28667;
			short num2 = num;
			num = -28667;
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
			LNameSet.Content = value;
		}
	}

	public string TXTPrice
	{
		get
		{
			short num = 0;
			_ = num;
			num = 6448;
			short num2 = num;
			num = 6448;
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
			num = -15694;
			short num2 = num;
			num = -15694;
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
			LPrice.Content = value;
		}
	}

	public string TXTPriceDiscount
	{
		get
		{
			short num = 0;
			_ = num;
			num = 18161;
			short num2 = num;
			num = 18161;
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
				return LPriceDiscount.Content.ToString();
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
			num = 6151;
			short num2 = num;
			num = 6151;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			LPriceDiscount.Content = value;
		}
	}

	public string TXTDescription
	{
		get
		{
			short num = 0;
			_ = num;
			num = 13257;
			short num2 = num;
			num = 13257;
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
				return TxtDescr.Text.ToString();
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = -11034;
			short num2 = num;
			num = -11034;
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
			TxtDescr.Text = value;
		}
	}

	public string TXTItems
	{
		get
		{
			short num = 0;
			_ = num;
			num = 1;
			if (num != 0)
			{
			}
			num = 14145;
			short num2 = num;
			num = 14145;
			switch (num2 == num)
			{
			default:
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
			num = -16941;
			short num2 = num;
			num = -16941;
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
				num = 1141;
				short num2 = num;
				num = 1141;
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

	public string TXTCmd
	{
		get
		{
			short num = 0;
			_ = num;
			num = -8632;
			short num2 = num;
			num = -8632;
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
			num = -26487;
			short num2 = num;
			num = -26487;
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
			Cmd = value;
		}
	}

	public string TXTPriceby
	{
		get
		{
			short num = 0;
			_ = num;
			num = 12380;
			short num2 = num;
			num = 12380;
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
			num = -32128;
			short num2 = num;
			num = -32128;
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

	public Shopset()
	{
		InitializeComponent();
	}

	private void eval_a(object A_0, MouseButtonEventArgs A_1)
	{
		short num = 3;
		int num2 = num;
		MainWindow mainWindow = default(MainWindow);
		MessageBoxResult messageBoxResult = default(MessageBoxResult);
		while (true)
		{
			switch (num2)
			{
			case 3:
				switch (0)
				{
				default:
					continue;
				case 0:
					break;
				}
				goto default;
			default:
				mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
				{
					short num4 = 0;
					_ = num4;
					num4 = 920;
					short num5 = num4;
					num4 = 920;
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
				num = 1;
				num2 = num;
				continue;
			case 4:
				num = 6;
				num2 = num;
				continue;
			case 6:
				if (messageBoxResult == MessageBoxResult.Yes)
				{
					num = 5;
					num2 = num;
					continue;
				}
				return;
			case 2:
				messageBoxResult = MessageBoxWindow.Show(this, "Вы уверены что хотите приобрести данный товар - " + MainWindow.Items_Name + "?", MainWindow.name_messege, MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
				num = 0;
				num2 = num;
				continue;
			case 0:
			{
				num = 13197;
				short num3 = num;
				num = 13197;
				switch (num3 == num)
				{
				default:
					num = 0;
					_ = num;
					goto case true;
				case true:
					num = 0;
					if (num == 0)
					{
					}
					goto IL_0146;
				case false:
				case true:
					break;
				}
				break;
			}
			case 5:
				mainWindow.GOBUY();
				num = 7;
				num2 = num;
				continue;
			case 7:
				return;
			case 1:
				{
					if (MainWindow.Langve == "RU")
					{
						num = 2;
						num2 = num;
						continue;
					}
					messageBoxResult = MessageBoxWindow.Show(this, "Are you sure you want to purchase this product - " + MainWindow.Items_Name + "?", MainWindow.name_messege, MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
					break;
				}
				IL_0146:
				num = 1;
				if (num == 0)
				{
				}
				goto case 4;
			}
			num = 4;
			num2 = num;
		}
	}
}
