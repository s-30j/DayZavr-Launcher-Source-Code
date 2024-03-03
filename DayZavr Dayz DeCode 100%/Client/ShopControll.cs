using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using Launcher;

namespace Client;

public partial class ShopControll : UserControl, IComponentConnector
{
	public static bool OpenBLOOT;

	public static bool OpenBWEAPON;

	public static bool OpenBSETS;

	public static bool OpenBCARS;

	public static bool OpenBInvent;

	public static bool OpenBMask;

	public static bool OpenBBase;

	public static bool OpenBMedic;

	internal ShopControll SHOPControll;

	internal Border Border2;

	internal StackPanel SLoot;

	internal Button BLOOT;

	internal Image Lootline;

	internal StackPanel SSet;

	internal Button BSETS;

	internal Image Setsline;

	internal StackPanel SWeapon;

	internal Button BWEAPON;

	internal Image Weaponline;

	internal StackPanel SCar;

	internal Button BCARS;

	internal Image Carsline;

	internal StackPanel SHeli;

	internal Button BHeli;

	internal Image Heliline;

	internal StackPanel SMask;

	internal Button BMask;

	internal Image Maskline;

	internal StackPanel SBase;

	internal Button BBase;

	internal Image Baseline;

	internal StackPanel SMedic;

	internal Button BMedic;

	internal Image Medicline;

	internal Grid GLIST;

	public ListBox BoxShop;

	internal Button BInfoShop;

	internal Grid GInfoShop;

	internal Button BCloseShopInfo;

	internal TextBlock TextW;

	internal TextBlock TextSet;

	internal TextBlock TextLoot;

	internal TextBlock TextBase;

	internal Image imgWarning;

	public ShopControll()
	{
		InitializeComponent();
	}

	private void eval_j(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_001f;
				case 0:
					break;
				}
				goto default;
			default:
				if (!OpenBLOOT)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = 0;
				_ = num;
				num = 5095;
				short num3 = num;
				num = 5095;
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
					OpenBMedic = false;
					OpenBBase = false;
					OpenBMask = false;
					OpenBInvent = false;
					OpenBWEAPON = false;
					OpenBSETS = false;
					OpenBCARS = false;
					OpenBLOOT = true;
					OpenGLIST();
					break;
				case false:
				case true:
					break;
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_001f:
				break;
			}
		}
	}

	private void eval_i(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_001f;
				case 0:
					break;
				}
				goto default;
			default:
				if (!OpenBWEAPON)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = 0;
				_ = num;
				num = 1;
				if (num != 0)
				{
				}
				num = -6144;
				short num3 = num;
				num = -6144;
				switch (num3 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					OpenBMedic = false;
					OpenBBase = false;
					OpenBMask = false;
					OpenBInvent = false;
					OpenBSETS = false;
					OpenBCARS = false;
					OpenBLOOT = false;
					OpenBWEAPON = true;
					OpenGLIST();
					break;
				case false:
				case true:
					break;
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_001f:
				break;
			}
		}
	}

	private void eval_h(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_001f;
				case 0:
					break;
				}
				goto default;
			default:
				if (!OpenBSETS)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = 0;
				_ = num;
				num = 27124;
				short num3 = num;
				num = 27124;
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
					OpenBMedic = false;
					OpenBBase = false;
					OpenBMask = false;
					OpenBInvent = false;
					OpenBWEAPON = false;
					OpenBLOOT = false;
					OpenBCARS = false;
					OpenBSETS = true;
					OpenGLIST();
					break;
				case false:
				case true:
					break;
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_001f:
				break;
			}
		}
	}

	private void eval_g(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_001f;
				case 0:
					break;
				}
				goto default;
			default:
				if (!OpenBCARS)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = 0;
				_ = num;
				num = 3229;
				short num3 = num;
				num = 3229;
				switch (num3 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					OpenBMedic = false;
					OpenBBase = false;
					OpenBMask = false;
					OpenBInvent = false;
					OpenBWEAPON = false;
					OpenBLOOT = false;
					OpenBSETS = false;
					OpenBCARS = true;
					OpenGLIST();
					break;
				case false:
				case true:
					break;
				}
				num = 1;
				if (num != 0)
				{
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_001f:
				break;
			}
		}
	}

	private void eval_f(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_0020;
				case 0:
					break;
				}
				goto default;
			default:
				if (!OpenBInvent)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = 0;
				_ = num;
				num = 26208;
				short num3 = num;
				num = 26208;
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
					OpenBMedic = false;
					OpenBBase = false;
					OpenBMask = false;
					OpenBWEAPON = false;
					OpenBSETS = false;
					OpenBCARS = false;
					OpenBLOOT = false;
					OpenBInvent = true;
					OpenGLIST();
					break;
				case false:
				case true:
					break;
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_0020:
				break;
			}
		}
	}

	private void eval_e(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_0020;
				case 0:
					break;
				}
				goto default;
			default:
				if (!OpenBMask)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = 0;
				_ = num;
				num = 30418;
				short num3 = num;
				num = 30418;
				switch (num3 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					OpenBMedic = false;
					OpenBBase = false;
					OpenBWEAPON = false;
					OpenBSETS = false;
					OpenBCARS = false;
					OpenBLOOT = false;
					OpenBInvent = false;
					OpenBMask = true;
					OpenGLIST();
					break;
				case false:
				case true:
					break;
				}
				num = 1;
				if (num != 0)
				{
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_0020:
				break;
			}
		}
	}

	private void eval_d(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_0020;
				case 0:
					break;
				}
				goto default;
			default:
				num = 1;
				if (num != 0)
				{
				}
				if (!OpenBBase)
				{
					num = 0;
					_ = num;
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = 23624;
				short num3 = num;
				num = 23624;
				switch (num3 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					OpenBMedic = false;
					OpenBWEAPON = false;
					OpenBSETS = false;
					OpenBCARS = false;
					OpenBLOOT = false;
					OpenBInvent = false;
					OpenBMask = false;
					OpenBBase = true;
					OpenGLIST();
					break;
				case false:
				case true:
					break;
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_0020:
				break;
			}
		}
	}

	private void eval_c(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_001f;
				case 0:
					break;
				}
				goto default;
			default:
				if (!OpenBMedic)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = 0;
				_ = num;
				num = -3419;
				short num3 = num;
				num = -3419;
				switch (num3 == num)
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
					OpenBWEAPON = false;
					OpenBSETS = false;
					OpenBCARS = false;
					OpenBLOOT = false;
					OpenBInvent = false;
					OpenBMask = false;
					OpenBBase = false;
					OpenBMedic = true;
					OpenGLIST();
					break;
				case false:
				case true:
					break;
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_001f:
				break;
			}
		}
	}

	public void OpenGLIST()
	{
		short num = 0;
		_ = num;
		num = 1;
		if (num != 0)
		{
		}
		num = 17917;
		short num2 = num;
		num = 17917;
		switch (num2 == num)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		BoxShop.Items.Clear();
		Lootline.Visibility = Visibility.Hidden;
		Weaponline.Visibility = Visibility.Hidden;
		Setsline.Visibility = Visibility.Hidden;
		Carsline.Visibility = Visibility.Hidden;
		Heliline.Visibility = Visibility.Hidden;
		Maskline.Visibility = Visibility.Hidden;
		Baseline.Visibility = Visibility.Hidden;
		Medicline.Visibility = Visibility.Hidden;
		BLOOT.IsEnabled = false;
		BSETS.IsEnabled = false;
		BCARS.IsEnabled = false;
		BWEAPON.IsEnabled = false;
		BHeli.IsEnabled = false;
		BMask.IsEnabled = false;
		BBase.IsEnabled = false;
		BMedic.IsEnabled = false;
		Thread thread = new Thread((Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
		{
			short num3 = 0;
			_ = num3;
			num3 = 1;
			if (num3 != 0)
			{
			}
			num3 = 30157;
			short num4 = num3;
			num3 = 30157;
			switch (num4 == num3)
			{
			default:
				num3 = 0;
				if (num3 != 0)
				{
				}
				return A_0 is MainWindow;
			}
		}) as MainWindow).Download_LoadXML);
		thread.IsBackground = true;
		thread.Start();
	}

	private void eval_b(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_001f;
				case 0:
					break;
				}
				goto default;
			default:
				if (GInfoShop.Visibility == Visibility.Hidden)
				{
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = 0;
				_ = num;
				num = -23049;
				short num3 = num;
				num = -23049;
				switch (num3 == num)
				{
				default:
				{
					num = 0;
					if (num != 0)
					{
					}
					GInfoShop.Visibility = Visibility.Visible;
					DoubleAnimation animation = new DoubleAnimation
					{
						From = 0.0,
						To = 1.0,
						Duration = new Duration(TimeSpan.FromSeconds(0.2)),
						AutoReverse = false
					};
					GInfoShop.BeginAnimation(UIElement.OpacityProperty, animation);
					break;
				}
				case false:
				case true:
					break;
				}
				num = 1;
				if (num != 0)
				{
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_001f:
				break;
			}
		}
	}

	private void eval_a(object A_0, RoutedEventArgs A_1)
	{
		short num = 1;
		int num2 = num;
		while (true)
		{
			num = 1;
			if (num != 0)
			{
			}
			switch (num2)
			{
			case 1:
				switch (0)
				{
				default:
					goto end_IL_0048;
				case 0:
					break;
				}
				goto default;
			default:
				if (GInfoShop.Visibility == Visibility.Visible)
				{
					num = 0;
					_ = num;
					num = 0;
					num2 = num;
					break;
				}
				return;
			case 0:
			{
				num = -11206;
				short num3 = num;
				num = -11206;
				switch (num3 == num)
				{
				default:
				{
					num = 0;
					if (num != 0)
					{
					}
					DoubleAnimation doubleAnimation = new DoubleAnimation
					{
						From = 1.0,
						To = 0.0,
						Duration = new Duration(TimeSpan.FromSeconds(0.2)),
						AutoReverse = false
					};
					doubleAnimation.Completed += delegate
					{
						short num4 = 0;
						_ = num4;
						num4 = 27172;
						short num5 = num4;
						num4 = 27172;
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
							GInfoShop.Visibility = Visibility.Hidden;
							break;
						}
					};
					GInfoShop.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
					break;
				}
				case false:
				case true:
					break;
				}
				num = 2;
				num2 = num;
				break;
			}
			case 2:
				return;
				end_IL_0048:
				break;
			}
		}
	}

	[CompilerGenerated]
	private void eval_a(object A_0, EventArgs A_1)
	{
		short num = 0;
		_ = num;
		num = 27172;
		short num2 = num;
		num = 27172;
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
		GInfoShop.Visibility = Visibility.Hidden;
	}
}
