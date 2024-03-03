using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using Launcher;
using LoadingIndicators.WPF;

namespace Client;

public partial class StatsControll : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private sealed class eval_a
	{
		public MainWindow eval_a;

		internal void eval_b(object A_0, EventArgs A_1)
		{
			short num = 0;
			_ = num;
			num = -12488;
			short num2 = num;
			num = -12488;
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
			eval_a.eval_fm.Visibility = Visibility.Hidden;
		}
	}

	internal StatsControll STATSControll;

	internal Label TXT;

	internal TabControl TabStats;

	internal TabItem TabALL;

	internal Label UserCountALL;

	public ListBox BoxALL;

	internal TabItem TabDistancion;

	internal Label UserCountDistancion;

	public ListBox BoxDistancion;

	internal TabItem TabShoot;

	internal Label UserCountShoot;

	public ListBox BoxShoot;

	internal TabItem TabKills;

	internal Label UserCountKills;

	public ListBox BoxKills;

	internal TabItem TabKillZ;

	internal Label UserCountKillZ;

	public ListBox BoxKillZ;

	internal TabItem TabAnimall;

	internal Label UserCountAnimalls;

	public ListBox BoxAnimall;

	internal TabItem TabTime;

	internal Label UserCountTime;

	public ListBox BoxTime;

	internal Label LError;

	internal Button BCloseStats;

	internal LoadingIndicator ThreeDots;

	public StatsControll()
	{
		InitializeComponent();
	}

	private void eval_a(object A_0, RoutedEventArgs A_1)
	{
		short num = 0;
		_ = num;
		num = 1;
		if (num != 0)
		{
		}
		num = 21958;
		short num2 = num;
		num = 21958;
		switch (num2 == num)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		MainWindow eval_a = Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
		{
			short num5 = 0;
			_ = num5;
			num5 = -27443;
			short num6 = num5;
			num5 = -27443;
			switch (num6 == num5)
			{
			default:
				num5 = 1;
				if (num5 != 0)
				{
				}
				num5 = 0;
				if (num5 != 0)
				{
				}
				return A_0 is MainWindow;
			}
		}) as MainWindow;
		eval_a.eval_fm.Visibility = Visibility.Visible;
		DoubleAnimation doubleAnimation = new DoubleAnimation
		{
			From = 1.0,
			To = 0.0,
			Duration = new Duration(TimeSpan.FromSeconds(0.2)),
			AutoReverse = false
		};
		doubleAnimation.Completed += delegate
		{
			short num3 = 0;
			_ = num3;
			num3 = -12488;
			short num4 = num3;
			num3 = -12488;
			switch (num4 == num3)
			{
			default:
				num3 = 1;
				if (num3 != 0)
				{
				}
				num3 = 0;
				if (num3 != 0)
				{
				}
				eval_a.eval_fm.Visibility = Visibility.Hidden;
				break;
			}
		};
		eval_a.eval_fm.BeginAnimation(UIElement.OpacityProperty, doubleAnimation);
	}
}
