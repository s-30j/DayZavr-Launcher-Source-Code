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

public partial class ShopWeapon : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private string _003CPriceby_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CSET_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CCmd_003Ek__BackingField;

	internal ShopWeapon SHOPLOOTControll;

	internal Border Border2;

	internal StackPanel XStack;

	internal TextBlock Info;

	internal Image ImageTollTip;

	internal RichTextBox RichTxt;

	internal Border Border2_Copy;

	internal ImageAwesome ImSH;

	internal Label LNameSet;

	internal Label LPrice;

	internal Label LTXTPRICE;

	internal Border GTXTD;

	internal TextBlock TxtDescr;

	internal Button BBuy;

	internal Label LPriceDiscount;

	internal Label LTXTPDISCOUNT;

	private string Priceby
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 11695;
			short num2 = num;
			num = 11695;
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
			short num = -30751;
			short num2 = num;
			num = -30751;
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
			_003CPriceby_003Ek__BackingField = value;
		}
	}

	public string SET
	{
		[CompilerGenerated]
		get
		{
			short num = 19193;
			short num2 = num;
			num = 19193;
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
				return _003CSET_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 27710;
			short num2 = num;
			num = 27710;
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
			_003CSET_003Ek__BackingField = value;
		}
	}

	public string Cmd
	{
		[CompilerGenerated]
		get
		{
			short num = -4267;
			short num2 = num;
			num = -4267;
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
				return _003CCmd_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 8188;
			short num2 = num;
			num = 8188;
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
			_003CCmd_003Ek__BackingField = value;
		}
	}

	public string TXTName
	{
		get
		{
			short num = -23205;
			short num2 = num;
			num = -23205;
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
				return LNameSet.Content.ToString();
			}
		}
		set
		{
			short num = 13540;
			short num2 = num;
			num = 13540;
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
			LNameSet.Content = value;
		}
	}

	public string TXTPrice
	{
		get
		{
			short num = 18292;
			short num2 = num;
			num = 18292;
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
				return LPrice.Content.ToString();
			}
		}
		set
		{
			short num = -18618;
			short num2 = num;
			num = -18618;
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
			LPrice.Content = value;
		}
	}

	public string TXTPriceDiscount
	{
		get
		{
			short num = -23795;
			short num2 = num;
			num = -23795;
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
				return LPriceDiscount.Content.ToString();
			}
		}
		set
		{
			short num = 4907;
			short num2 = num;
			num = 4907;
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
			LPriceDiscount.Content = value;
		}
	}

	public string TXTItems
	{
		get
		{
			short num = 2524;
			short num2 = num;
			num = 2524;
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
				return SET;
			}
		}
		set
		{
			short num = 26577;
			short num2 = num;
			num = 26577;
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
			SET = value;
		}
	}

	public string TXTDescription
	{
		get
		{
			short num = 28083;
			short num2 = num;
			num = 28083;
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
				return TxtDescr.Text.ToString();
			}
		}
		set
		{
			short num = 32686;
			short num2 = num;
			num = 32686;
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
			TxtDescr.Text = value;
		}
	}

	public string IMGSHOP
	{
		get
		{
			short num = -27693;
			short num2 = num;
			num = -27693;
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
				return ImSH.Source.ToString();
			}
		}
		set
		{
			short num;
			try
			{
				num = -13330;
				short num2 = num;
				num = -13330;
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
			short num = 28436;
			short num2 = num;
			num = 28436;
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
				return Cmd;
			}
		}
		set
		{
			short num = -24820;
			short num2 = num;
			num = -24820;
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
			Cmd = value;
		}
	}

	public string TXTPriceby
	{
		get
		{
			short num = 17395;
			short num2 = num;
			num = 17395;
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
				return Priceby;
			}
		}
		set
		{
			short num = 3532;
			short num2 = num;
			num = 3532;
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
			Priceby = value;
		}
	}

	public ShopWeapon()
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
					short num4 = -18409;
					short num5 = num4;
					num4 = -18409;
					switch (num5 == num4)
					{
					default:
						num4 = 0;
						_ = num4;
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
				num = 2;
				num2 = num;
				break;
			case 5:
			case 7:
				num = 4;
				num2 = num;
				break;
			case 4:
				if (messageBoxResult != MessageBoxResult.Yes)
				{
					return;
				}
				goto IL_007e;
			case 1:
				num = 1;
				if (num != 0)
				{
				}
				mainWindow.GOBUY();
				num = 3;
				num2 = num;
				break;
			case 6:
				messageBoxResult = MessageBoxWindow.Show(this, "Вы уверены что хотите приобрести данный товар - " + MainWindow.Items_Name + "?", MainWindow.name_messege, MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
				num = 5;
				num2 = num;
				break;
			case 3:
				return;
			case 2:
				{
					num = 78;
					short num3 = num;
					num = 78;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						num = 0;
						if (num != 0)
						{
						}
						num = 0;
						_ = num;
						if (MainWindow.Langve == "RU")
						{
							num = 6;
							num2 = num;
						}
						else
						{
							messageBoxResult = MessageBoxWindow.Show(this, "Are you sure you want to purchase this product - " + MainWindow.Items_Name + "?", MainWindow.name_messege, MessageBoxButton.YesNo, MessageBoxImage.Asterisk);
							num = 7;
							num2 = num;
						}
						goto end_IL_001f;
					}
					goto IL_007e;
				}
				IL_007e:
				num = 1;
				num2 = num;
				break;
				end_IL_001f:
				break;
			}
		}
	}

	private void eval_a(object A_0, MouseEventArgs A_1)
	{
		short num = -12918;
		short num2 = num;
		num = -12918;
		switch (num2 == num)
		{
		default:
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
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
		Info.Text = TXTName;
	}
}
