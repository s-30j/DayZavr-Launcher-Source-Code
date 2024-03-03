using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media.Animation;
using Hardcodet.Wpf.TaskbarNotification;

namespace Samples;

public partial class FancyBalloon : UserControl, IComponentConnector
{
	private bool isClosing;

	public static readonly DependencyProperty BalloonTextProperty;

	public static readonly DependencyProperty TextProperty;

	internal FancyBalloon me;

	internal BeginStoryboard FadeIn_BeginStoryboard;

	internal BeginStoryboard HighlightCloseButton_BeginStoryboard;

	internal BeginStoryboard FadeCloseButton_BeginStoryboard;

	internal BeginStoryboard FadeBack_BeginStoryboard1;

	internal BeginStoryboard FadeOut_BeginStoryboard;

	internal Grid grid;

	internal TextBlock TextBallon;

	internal Image imgClose;

	public string BalloonText
	{
		get
		{
			short num = -10369;
			short num2 = num;
			num = -10369;
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
				return (string)GetValue(BalloonTextProperty);
			}
		}
		set
		{
			short num = 3085;
			short num2 = num;
			num = 3085;
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
			SetValue(BalloonTextProperty, value);
		}
	}

	public string Text
	{
		get
		{
			short num = -12416;
			short num2 = num;
			num = -12416;
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
				return (string)GetValue(TextProperty);
			}
		}
		set
		{
			short num = -24906;
			short num2 = num;
			num = -24906;
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
			SetValue(TextProperty, value);
		}
	}

	public FancyBalloon()
	{
		InitializeComponent();
		TaskbarIcon.AddBalloonClosingHandler(this, eval_a);
	}

	private void eval_a(object A_0, RoutedEventArgs A_1)
	{
		short num = -16392;
		short num2 = num;
		num = -16392;
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
		A_1.Handled = true;
		isClosing = true;
	}

	private void eval_a(object A_0, MouseButtonEventArgs A_1)
	{
		short num = -13556;
		short num2 = num;
		num = -13556;
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
		TaskbarIcon.GetParentTaskbarIcon(this).CloseBalloon();
	}

	private void eval_a(object A_0, MouseEventArgs A_1)
	{
		if (isClosing)
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			num = -19141;
			short num2 = num;
			num = -19141;
			switch (num2 == num)
			{
			case false:
			case true:
				return;
			}
			num = 0;
			if (num == 0)
			{
			}
		}
		else
		{
			TaskbarIcon.GetParentTaskbarIcon(this).ResetBalloonCloseTimer();
		}
	}

	private void eval_a(object A_0, EventArgs A_1)
	{
		short num = 21087;
		short num2 = num;
		num = 21087;
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
		((Popup)base.Parent).IsOpen = false;
	}

	static FancyBalloon()
	{
		short num = -5859;
		short num2 = num;
		num = -5859;
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
		BalloonTextProperty = DependencyProperty.Register("BalloonText", typeof(string), typeof(FancyBalloon), new FrameworkPropertyMetadata(string.Empty));
		TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(FancyBalloon), new FrameworkPropertyMetadata(string.Empty));
	}
}
