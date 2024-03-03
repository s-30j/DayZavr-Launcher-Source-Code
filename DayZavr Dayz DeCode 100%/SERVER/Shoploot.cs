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

public partial class Shoploot : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private string _003CPriceby_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CSET_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CCmd_003Ek__BackingField;

	internal Shoploot SHOPLOOTControll;

	internal Border Border2;

	internal StackPanel XStack;

	internal TextBlock Info;

	internal Image ImageTollTip;

	internal RichTextBox RichTxt;

	internal Label LNameSet;

	internal Label LPrice;

	internal Label LTXTPRICE;

	internal Label LPriceDiscount;

	internal Label LTXTPDISCOUNT;

	internal Border GTXTD;

	internal TextBlock TxtDescr;

	internal Button BBuy;

	internal Border Border2_Copy;

	internal ImageAwesome ImSH;

	private string Priceby
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = -16527;
			short num2 = num;
			num = -16527;
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
			num = -10664;
			short num2 = num;
			num = -10664;
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
			num = 5473;
			short num2 = num;
			num = 5473;
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
			num = 20022;
			short num2 = num;
			num = 20022;
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
			num = 27241;
			short num2 = num;
			num = 27241;
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
			num = -29233;
			short num2 = num;
			num = -29233;
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
			num = 937;
			short num2 = num;
			num = 937;
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
			num = 1;
			if (num != 0)
			{
			}
			num = 18440;
			short num2 = num;
			num = 18440;
			switch (num2 == num)
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
			num = 1;
			if (num != 0)
			{
			}
			num = -2017;
			short num2 = num;
			num = -2017;
			switch (num2 == num)
			{
			default:
				num = 0;
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
			num = -12290;
			short num2 = num;
			num = -12290;
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
			LPrice.Content = value;
		}
	}

	public string TXTPriceDiscount
	{
		get
		{
			short num = 0;
			_ = num;
			num = 16470;
			short num2 = num;
			num = 16470;
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
			num = 6374;
			short num2 = num;
			num = 6374;
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

	public string TXTPriceby
	{
		get
		{
			short num = 0;
			_ = num;
			num = 1;
			if (num != 0)
			{
			}
			num = 17908;
			short num2 = num;
			num = 17908;
			switch (num2 == num)
			{
			default:
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
			num = 14762;
			short num2 = num;
			num = 14762;
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

	public string TXTItems
	{
		get
		{
			short num = 0;
			_ = num;
			num = 4019;
			short num2 = num;
			num = 4019;
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
			num = 1;
			if (num != 0)
			{
			}
			num = -21244;
			short num2 = num;
			num = -21244;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			SET = value;
		}
	}

	public string TXTDescription
	{
		get
		{
			short num = 0;
			_ = num;
			num = -29024;
			short num2 = num;
			num = -29024;
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
			num = -18939;
			short num2 = num;
			num = -18939;
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

	public string IMGSHOP
	{
		get
		{
			short num = 0;
			_ = num;
			num = -18669;
			short num2 = num;
			num = -18669;
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
				return ImSH.Source.ToString();
			}
		}
		set
		{
			short num;
			try
			{
				num = 30653;
				short num2 = num;
				num = 30653;
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
			num = -7502;
			short num2 = num;
			num = -7502;
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
				return Cmd;
			}
		}
		set
		{
			short num = 0;
			_ = num;
			num = 14223;
			short num2 = num;
			num = 14223;
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
			Cmd = value;
		}
	}

	public Shoploot()
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
					num4 = -12603;
					short num5 = num4;
					num4 = -12603;
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
				goto IL_0063;
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
				num = -29858;
				short num3 = num;
				num = -29858;
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
					goto IL_0063;
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
				num = 1;
				if (num == 0)
				{
				}
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
				IL_0063:
				num = 6;
				num2 = num;
				continue;
			}
			num = 4;
			num2 = num;
		}
	}

	private void eval_a(object A_0, MouseEventArgs A_1)
	{
		short num = -22237;
		short num2 = num;
		num = -22237;
		switch (num2 == num)
		{
		default:
			num = 0;
			if (num != 0)
			{
			}
			RichTxt.Document.Blocks.Clear();
			RichTxt.AppendText(TXTDescription + "\r");
			try
			{
				ImageTollTip.Source = new BitmapImage(new Uri(IMGSHOP));
			}
			catch
			{
			}
			break;
		case false:
		case true:
			break;
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		_ = num;
		Info.Text = TXTName;
	}
}
