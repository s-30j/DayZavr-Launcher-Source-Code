using System;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using Dinobenz.Wpf.MessageBox.View;
using FontAwesome.WPF;
using Launcher;

namespace SERVER;

public partial class SControll : UserControl, IComponentConnector
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct eval_a : IAsyncStateMachine
	{
		public int eval_a;

		public AsyncVoidMethodBuilder eval_b;

		public SControll eval_c;

		private TaskAwaiter m_eval_d;

		private void eval_d()
		{
			short num = 0;
			_ = num;
			num = 10475;
			short num2 = num;
			num = 10475;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				num = 0;
				switch (num)
				{
				}
				break;
			case false:
			case true:
				break;
			}
			int num3 = eval_a;
			SControll sControll = eval_c;
			try
			{
				num = 8;
				int num4 = num;
				TaskAwaiter awaiter = default(TaskAwaiter);
				MainWindow mainWindow = default(MainWindow);
				while (true)
				{
					object mod_in;
					switch (num4)
					{
					case 3:
						break;
					case 8:
						switch (0)
						{
						default:
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						if (num3 != 0)
						{
							num = 9;
							num4 = num;
							continue;
						}
						awaiter = this.m_eval_d;
						this.m_eval_d = default(TaskAwaiter);
						num3 = (eval_a = -1);
						num = 4;
						num4 = num;
						continue;
					case 5:
						num3 = (eval_a = 0);
						this.m_eval_d = awaiter;
						eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num = 11;
						num4 = num;
						continue;
					case 11:
						goto end_IL_00b9;
					case 19:
						mod_in = "";
						goto IL_02b5;
					case 7:
						num = 0;
						num4 = num;
						continue;
					case 0:
						if (!string.IsNullOrEmpty(MainWindow.Connectport))
						{
							num = 10;
							num4 = num;
						}
						else
						{
							num = 13;
							num4 = num;
						}
						continue;
					case 4:
						awaiter.GetResult();
						num = 17;
						num4 = num;
						continue;
					case 9:
						MainWindow.CheckGameMods = false;
						MainWindow.IfStopedUload = true;
						num = 20;
						num4 = num;
						continue;
					case 20:
						mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
						{
							short num5 = 22032;
							short num6 = num5;
							num5 = 22032;
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
								num5 = 0;
								_ = num5;
								return A_0 is MainWindow;
							}
						}) as MainWindow;
						num = 1;
						num4 = num;
						continue;
					case 14:
						if (string.IsNullOrEmpty(MainWindow.Connectip))
						{
							num = 7;
							num4 = num;
							continue;
						}
						goto case 10;
					case 10:
						awaiter = mainWindow.CheckGameFile().GetAwaiter();
						num = 6;
						num4 = num;
						continue;
					case 6:
						if (!awaiter.IsCompleted)
						{
							num = 5;
							num4 = num;
							continue;
						}
						goto case 4;
					case 15:
						num = 18;
						num4 = num;
						continue;
					case 18:
						mod_in = sControll.MODS_;
						goto IL_02b5;
					case 13:
						if (MainWindow.Langve == "RU")
						{
							num = 2;
							num4 = num;
						}
						else
						{
							MessageBoxWindow.Show(sControll, "You did not select a server.", MainWindow.name_messege);
							num = 12;
							num4 = num;
						}
						continue;
					case 1:
						if (sControll.MODS_ == "")
						{
							num = 19;
							num4 = num;
						}
						else
						{
							num = 15;
							num4 = num;
						}
						continue;
					case 2:
						MessageBoxWindow.Show(sControll, "Вы не выбрали сервер.", MainWindow.name_messege);
						num = 16;
						num4 = num;
						continue;
					case 12:
					case 16:
					case 17:
						{
							num = 3;
							num4 = num;
							continue;
						}
						IL_02b5:
						MainWindow.Mod_in = (string)mod_in;
						MainWindow.Connectip = sControll.LIp_Host_;
						MainWindow.Connectport = sControll.LPort_host_;
						num = 14;
						num4 = num;
						continue;
					}
					break;
				}
				goto IL_00a1;
				end_IL_00b9:;
			}
			catch (Exception exception)
			{
				eval_a = -2;
				eval_b.SetException(exception);
			}
			goto IL_04af;
			IL_04af:
			num = 1;
			if (num == 0)
			{
			}
			return;
			IL_00a1:
			eval_a = -2;
			eval_b.SetResult();
			goto IL_04af;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in eval_d
			this.eval_d();
		}

		[DebuggerHidden]
		private void eval_d(IAsyncStateMachine A_0)
		{
			short num = 0;
			_ = num;
			num = 21115;
			short num2 = num;
			num = 21115;
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
			eval_b.SetStateMachine(A_0);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine A_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in eval_d
			this.eval_d(A_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct eval_b : IAsyncStateMachine
	{
		public int eval_a;

		public AsyncVoidMethodBuilder eval_b;

		public SControll eval_c;

		private TaskAwaiter m_eval_d;

		private void eval_d()
		{
			short num = 0;
			_ = num;
			num = 24824;
			short num2 = num;
			num = 24824;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				num = 0;
				switch (num)
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
			int num3 = eval_a;
			SControll sControll = eval_c;
			try
			{
				num = 1;
				int num4 = num;
				TaskAwaiter awaiter = default(TaskAwaiter);
				MainWindow mainWindow = default(MainWindow);
				while (true)
				{
					switch (num4)
					{
					case 1:
						switch (0)
						{
						default:
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						if (num3 != 0)
						{
							num = 0;
							num4 = num;
							continue;
						}
						awaiter = this.m_eval_d;
						this.m_eval_d = default(TaskAwaiter);
						num3 = (eval_a = -1);
						num = 5;
						num4 = num;
						continue;
					case 0:
						num = 6;
						num4 = num;
						continue;
					case 6:
						mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
						{
							short num5 = -4626;
							short num6 = num5;
							num5 = -4626;
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
								num5 = 0;
								_ = num5;
								return A_0 is MainWindow;
							}
						}) as MainWindow;
						num = 7;
						num4 = num;
						continue;
					case 8:
						num3 = (eval_a = 0);
						this.m_eval_d = awaiter;
						eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num = 4;
						num4 = num;
						continue;
					case 4:
						return;
					case 5:
						awaiter.GetResult();
						num = 3;
						num4 = num;
						continue;
					case 7:
						if (mainWindow.eval_fm.Visibility == Visibility.Hidden)
						{
							num = 10;
							num4 = num;
							continue;
						}
						break;
					case 10:
					{
						mainWindow.eval_fm.Visibility = Visibility.Visible;
						DoubleAnimation animation = new DoubleAnimation
						{
							From = 0.0,
							To = 1.0,
							Duration = new Duration(TimeSpan.FromSeconds(0.2)),
							AutoReverse = false
						};
						mainWindow.eval_fm.BeginAnimation(UIElement.OpacityProperty, animation);
						MainWindow.FirstRunStatistic = false;
						awaiter = mainWindow.LoadStatistic(sControll.LPort_host_).GetAwaiter();
						num = 9;
						num4 = num;
						continue;
					}
					case 9:
						if (!awaiter.IsCompleted)
						{
							num = 8;
							num4 = num;
							continue;
						}
						goto case 5;
					case 3:
						break;
					case 2:
						goto end_IL_00fe;
					}
					num = 2;
					num4 = num;
					continue;
					end_IL_00fe:
					break;
				}
			}
			catch (Exception exception)
			{
				eval_a = -2;
				eval_b.SetException(exception);
				return;
			}
			eval_a = -2;
			eval_b.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in eval_d
			this.eval_d();
		}

		[DebuggerHidden]
		private void eval_d(IAsyncStateMachine A_0)
		{
			short num = 0;
			_ = num;
			num = -7898;
			short num2 = num;
			num = -7898;
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
			eval_b.SetStateMachine(A_0);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine A_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in eval_d
			this.eval_d(A_0);
		}
	}

	[CompilerGenerated]
	private string _003CNameOpenUser_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CWhitelist__003Ek__BackingField;

	[CompilerGenerated]
	private string _003CPassword__003Ek__BackingField;

	[CompilerGenerated]
	private string _003CIp_Host__003Ek__BackingField;

	[CompilerGenerated]
	private string _003CPort_host__003Ek__BackingField;

	[CompilerGenerated]
	private string _003CUDP_PORT__003Ek__BackingField;

	[CompilerGenerated]
	private string _003CMODS__003Ek__BackingField;

	[CompilerGenerated]
	private string _003CMODSEN__003Ek__BackingField;

	[CompilerGenerated]
	private string _003CPlayhost_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CSlotevery_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CPORT_VID_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CIP_VIDSCS_003Ek__BackingField;

	[CompilerGenerated]
	private string _003CDISKORD_003Ek__BackingField;

	internal SControll NewsControll;

	internal Border Border2;

	internal Grid GS;

	internal Border BORDER;

	internal Grid GNAME;

	internal Border BImg;

	internal ImageAwesome ImS;

	internal Border BNAMEPLAYERS_GStats;

	internal TextBlock TxtName_GStats;

	internal Border BtxtNAMEPLAYERS_GStats;

	public Label TextOnlain_GStats;

	internal Border BtxtTimeRestart_GStats;

	public Label TxtTimeRestart_GStats;

	internal Border BPING;

	internal Grid GPING;

	internal Label LPING;

	internal Border BPLAYER;

	internal Grid GPLAYER;

	internal Label LPLAYER;

	internal Label LNAME;

	internal Grid GBUT;

	internal Button BDiscord;

	internal Button BShop;

	internal Button BSTats;

	internal Button BSERVER;

	internal Label LGo;

	internal Button BSERVER_PCF;

	internal Label LPCF;

	public string NameOpenUser
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 25055;
			short num2 = num;
			num = 25055;
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
				return _003CNameOpenUser_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -12833;
			short num2 = num;
			num = -12833;
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
			_003CNameOpenUser_003Ek__BackingField = value;
		}
	}

	public string Whitelist_
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = -14722;
			short num2 = num;
			num = -14722;
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
				return _003CWhitelist__003Ek__BackingField;
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
			num = 17627;
			short num2 = num;
			num = 17627;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			_003CWhitelist__003Ek__BackingField = value;
		}
	}

	public string Password_
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = -27300;
			short num2 = num;
			num = -27300;
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
				return _003CPassword__003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -17054;
			short num2 = num;
			num = -17054;
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
			_003CPassword__003Ek__BackingField = value;
		}
	}

	public string Ip_Host_
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 22574;
			short num2 = num;
			num = 22574;
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
				return _003CIp_Host__003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = 13060;
			short num2 = num;
			num = 13060;
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
			_003CIp_Host__003Ek__BackingField = value;
		}
	}

	public string Port_host_
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 30429;
			short num2 = num;
			num = 30429;
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
				return _003CPort_host__003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -13322;
			short num2 = num;
			num = -13322;
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
			_003CPort_host__003Ek__BackingField = value;
		}
	}

	public string UDP_PORT_
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 3448;
			short num2 = num;
			num = 3448;
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
				return _003CUDP_PORT__003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = 21689;
			short num2 = num;
			num = 21689;
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
			_003CUDP_PORT__003Ek__BackingField = value;
		}
	}

	public string MODS_
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = -21488;
			short num2 = num;
			num = -21488;
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
				return _003CMODS__003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -7413;
			short num2 = num;
			num = -7413;
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
			_003CMODS__003Ek__BackingField = value;
		}
	}

	public string MODSEN_
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 19270;
			short num2 = num;
			num = 19270;
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
				return _003CMODSEN__003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = 17857;
			short num2 = num;
			num = 17857;
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
			_003CMODSEN__003Ek__BackingField = value;
		}
	}

	public string Playhost
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = -30603;
			short num2 = num;
			num = -30603;
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
				return _003CPlayhost_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -1369;
			short num2 = num;
			num = -1369;
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
			_003CPlayhost_003Ek__BackingField = value;
		}
	}

	public string Slotevery
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 1;
			if (num != 0)
			{
			}
			num = -29484;
			short num2 = num;
			num = -29484;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				return _003CSlotevery_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -3962;
			short num2 = num;
			num = -3962;
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
			_003CSlotevery_003Ek__BackingField = value;
		}
	}

	public string PORT_VID
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 15331;
			short num2 = num;
			num = 15331;
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
				return _003CPORT_VID_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -32363;
			short num2 = num;
			num = -32363;
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
			_003CPORT_VID_003Ek__BackingField = value;
		}
	}

	public string IP_VIDSCS
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 26940;
			short num2 = num;
			num = 26940;
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
				return _003CIP_VIDSCS_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 0;
			_ = num;
			num = -25266;
			short num2 = num;
			num = -25266;
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
			_003CIP_VIDSCS_003Ek__BackingField = value;
		}
	}

	public string DISKORD
	{
		[CompilerGenerated]
		get
		{
			short num = 0;
			_ = num;
			num = 1;
			if (num != 0)
			{
			}
			num = 21176;
			short num2 = num;
			num = 21176;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				return _003CDISKORD_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 16824;
			short num2 = num;
			num = 16824;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			_003CDISKORD_003Ek__BackingField = value;
		}
	}

	public string LWhitelist_
	{
		get
		{
			short num = 25415;
			short num2 = num;
			num = 25415;
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
				return Whitelist_;
			}
		}
		set
		{
			short num = -19225;
			short num2 = num;
			num = -19225;
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
			Whitelist_ = value;
		}
	}

	public string LPassword_
	{
		get
		{
			short num = -374;
			short num2 = num;
			num = -374;
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
				return Password_;
			}
		}
		set
		{
			short num = -20022;
			short num2 = num;
			num = -20022;
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
			Password_ = value;
		}
	}

	public string LIp_Host_
	{
		get
		{
			short num = 21990;
			short num2 = num;
			num = 21990;
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
				return Ip_Host_;
			}
		}
		set
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 12770;
			short num2 = num;
			num = 12770;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			Ip_Host_ = value;
		}
	}

	public string LPort_host_
	{
		get
		{
			short num = -19153;
			short num2 = num;
			num = -19153;
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
				return Port_host_;
			}
		}
		set
		{
			short num = 17583;
			short num2 = num;
			num = 17583;
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
			Port_host_ = value;
		}
	}

	public string LUDP_PORT_
	{
		get
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = -31200;
			short num2 = num;
			num = -31200;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				num = 0;
				_ = num;
				return UDP_PORT_;
			}
		}
		set
		{
			short num = -25579;
			short num2 = num;
			num = -25579;
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
			UDP_PORT_ = value;
		}
	}

	public string LMODS_
	{
		get
		{
			short num = 17951;
			short num2 = num;
			num = 17951;
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
				return MODS_;
			}
		}
		set
		{
			short num = 8580;
			short num2 = num;
			num = 8580;
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
			MODS_ = value;
		}
	}

	public string LMODSEN_
	{
		get
		{
			short num = -7818;
			short num2 = num;
			num = -7818;
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
				return MODSEN_;
			}
		}
		set
		{
			short num = -24858;
			short num2 = num;
			num = -24858;
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
			MODSEN_ = value;
		}
	}

	public string LPlayhost
	{
		get
		{
			short num = -25994;
			short num2 = num;
			num = -25994;
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
				return Playhost;
			}
		}
		set
		{
			short num = 4856;
			short num2 = num;
			num = 4856;
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
			Playhost = value;
		}
	}

	public string LSlotevery
	{
		get
		{
			short num = 12057;
			short num2 = num;
			num = 12057;
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
				return Slotevery;
			}
		}
		set
		{
			short num = 2116;
			short num2 = num;
			num = 2116;
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
			num = 0;
			_ = num;
			Slotevery = value;
		}
	}

	public string LPORT_VID
	{
		get
		{
			short num = -17368;
			short num2 = num;
			num = -17368;
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
				return PORT_VID;
			}
		}
		set
		{
			short num = 22707;
			short num2 = num;
			num = 22707;
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
			PORT_VID = value;
		}
	}

	public string LIP_VIDSCS
	{
		get
		{
			short num = -16876;
			short num2 = num;
			num = -16876;
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
				return IP_VIDSCS;
			}
		}
		set
		{
			short num = 18819;
			short num2 = num;
			num = 18819;
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
			num = 0;
			_ = num;
			IP_VIDSCS = value;
		}
	}

	public string LDISCORD
	{
		get
		{
			short num = 10886;
			short num2 = num;
			num = 10886;
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
				return DISKORD;
			}
		}
		set
		{
			short num = 4101;
			short num2 = num;
			num = 4101;
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
			num = 0;
			_ = num;
			DISKORD = value;
		}
	}

	public string LNAMESERVER
	{
		get
		{
			short num = 9826;
			short num2 = num;
			num = 9826;
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
				return LNAME.Content.ToString();
			}
		}
		set
		{
			short num = -4215;
			short num2 = num;
			num = -4215;
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
			LNAME.Content = value;
		}
	}

	public string LPLAYERSERVER
	{
		get
		{
			short num = 848;
			short num2 = num;
			num = 848;
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
				return LPLAYER.Content.ToString();
			}
		}
		set
		{
			short num = -23482;
			short num2 = num;
			num = -23482;
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
			LPLAYER.Content = value;
		}
	}

	public string LPINGSERVER
	{
		get
		{
			short num = -27820;
			short num2 = num;
			num = -27820;
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
				return LPING.Content.ToString();
			}
		}
		set
		{
			short num = -8118;
			short num2 = num;
			num = -8118;
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
			LPING.Content = value;
		}
	}

	public string LTIMERESTARTSERVER
	{
		get
		{
			short num = 25762;
			short num2 = num;
			num = 25762;
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
				return TxtTimeRestart_GStats.Content.ToString();
			}
		}
		set
		{
			short num = 10543;
			short num2 = num;
			num = 10543;
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
			num = 0;
			_ = num;
			TxtTimeRestart_GStats.Content = value;
		}
	}

	public string LPLAYERGAMESERVER
	{
		get
		{
			short num = -3549;
			short num2 = num;
			num = -3549;
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
				return TxtName_GStats.Text.ToString();
			}
		}
		set
		{
			short num = 21411;
			short num2 = num;
			num = 21411;
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
			TxtName_GStats.Text = value;
		}
	}

	public string IMGSERVER
	{
		set
		{
			short num;
			try
			{
				num = 23066;
				short num2 = num;
				num = 23066;
				switch (num2 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					ImS.Source = new BitmapImage(new Uri(value));
					break;
				}
			}
			catch
			{
				ImS.Source = new BitmapImage(new Uri("pack://application:,,/Design/shop.png"));
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
		}
	}

	public SControll()
	{
		InitializeComponent();
		try
		{
			foreach (FontFamily fontFamily in Fonts.GetFontFamilies(new Uri("pack://application:,,,/"), "./resources/fontn/"))
			{
				LNAME.FontFamily = fontFamily;
			}
		}
		catch
		{
		}
	}

	private void eval_e(object A_0, MouseButtonEventArgs A_1)
	{
		short num;
		try
		{
			num = 0;
			int num2 = num;
			switch (num2)
			{
			default:
				switch (0)
				{
				default:
				{
					MainWindow mainWindow = default(MainWindow);
					int num4 = default(int);
					Process[] processesByName = default(Process[]);
					bool flag = default(bool);
					while (true)
					{
						object mod_in;
						switch (num2)
						{
						case 6:
							mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
							{
								short num5 = 26352;
								short num6 = num5;
								num5 = 26352;
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
									num5 = 0;
									_ = num5;
									return A_0 is MainWindow;
								}
							}) as MainWindow;
							MainWindow.Connectip = LIp_Host_;
							MainWindow.Connectport = LPort_host_;
							MainWindow.connectudp = Convert.ToInt32(LUDP_PORT_);
							MainWindow.Playergame = LPlayhost;
							MainWindow.Playersslot = LSlotevery;
							MainWindow.NameServerForTimePlayed = LNAMESERVER;
							mainWindow.TextNameServer.Content = LNAMESERVER;
							MainWindow.IP_OUTVIDSCS = LIP_VIDSCS;
							MainWindow.Port_OUTVID = Convert.ToInt32(LPORT_VID);
							num = 2;
							num2 = num;
							continue;
						case 9:
							if (!MainWindow.UpdateStatus)
							{
								num = 17;
								num2 = num;
								continue;
							}
							goto case 12;
						case 8:
							mod_in = "";
							goto IL_0211;
						case 5:
							num = 15;
							num2 = num;
							continue;
						case 15:
							mod_in = MODS_;
							goto IL_0211;
						case 14:
							num = 18;
							num2 = num;
							continue;
						case 18:
							if (!string.IsNullOrEmpty(MainWindow.Connectport))
							{
								num = 4;
								num2 = num;
							}
							else
							{
								num = 0;
								num2 = num;
							}
							continue;
						case 4:
							num = 1;
							if (num == 0)
							{
							}
							goto IL_00bd;
						case 10:
							MessageBoxWindow.Show(this, "Вы не выбрали сервер.", MainWindow.name_messege);
							num = 12;
							num2 = num;
							continue;
						case 0:
							if (MainWindow.Langve == "RU")
							{
								num = 10;
								num2 = num;
							}
							else
							{
								MessageBoxWindow.Show(this, "You did not select a server.", MainWindow.name_messege);
								num = 16;
								num2 = num;
							}
							continue;
						case 1:
							try
							{
								Convert.ToInt32(MainWindow.Playergame);
								Convert.ToInt32(MainWindow.Playersslot);
							}
							catch
							{
							}
							_ = MainWindow.Connectip + MainWindow.Connectport;
							num = 13;
							num2 = num;
							continue;
						case 2:
							if (MODS_ == "")
							{
								num = 8;
								num2 = num;
							}
							else
							{
								num = 5;
								num2 = num;
							}
							continue;
						case 7:
							try
							{
								switch (0)
								{
								default:
									while (true)
									{
										num = -23737;
										short num3 = num;
										num = -23737;
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
												goto IL_0489;
											case 3:
											case 4:
												goto IL_04b0;
											case 10:
												goto IL_04c8;
											case 0:
												goto IL_04eb;
											case 7:
												goto IL_0551;
											case 8:
												goto IL_059d;
											case 5:
												goto IL_05b5;
											case 6:
											case 9:
											case 11:
												goto IL_05f7;
											case 1:
												goto end_IL_03e1;
											}
											break;
										case false:
										case true:
											goto IL_05f7;
											IL_04c8:
											if (num4 >= processesByName.Length)
											{
												num = 8;
												num2 = num;
												continue;
											}
											_ = processesByName[num4];
											flag = true;
											num4++;
											num = 4;
											num2 = num;
											continue;
											IL_05f7:
											num = 1;
											num2 = num;
											continue;
											IL_05b5:
											if (!flag)
											{
												num = 0;
												num2 = num;
											}
											else
											{
												mainWindow.Startclient();
												num = 6;
												num2 = num;
											}
											continue;
											IL_04b0:
											num = 10;
											num2 = num;
											continue;
											IL_0489:
											if (MainWindow.GameLicense)
											{
												num = 7;
												num2 = num;
											}
											else
											{
												mainWindow.Startclient();
												num = 9;
												num2 = num;
											}
											continue;
											IL_059d:
											num = 5;
											num2 = num;
											continue;
											IL_0551:
											flag = false;
											processesByName = Process.GetProcessesByName("steamwebhelper");
											num4 = 0;
											num = 3;
											num2 = num;
											continue;
											IL_04eb:
											MessageBoxWindow.Show(this, "Steam не запущен!", MainWindow.name_messege, MessageBoxButton.OK, MessageBoxImage.Exclamation);
											mainWindow.BoxServer.IsEnabled = true;
											num = 11;
											num2 = num;
											continue;
										}
										goto case 0;
										continue;
										end_IL_03e1:
										break;
									}
									break;
								case 0:
									mainWindow.BoxServer.IsEnabled = false;
									num = 2;
									num2 = num;
									goto default;
								}
							}
							catch
							{
								if (MainWindow.Langve == "RU")
								{
									MessageBoxWindow.Show(this, "Вы не выбрали сервер.", MainWindow.name_messege);
								}
								else
								{
									MessageBoxWindow.Show(this, "You did not select a server.", MainWindow.name_messege);
								}
								goto end_IL_0028;
							}
							goto case 12;
						case 17:
							num = 11;
							num2 = num;
							continue;
						case 11:
							if (string.IsNullOrEmpty(MainWindow.Connectip))
							{
								num = 14;
								num2 = num;
								continue;
							}
							goto IL_00bd;
						case 13:
							try
							{
								_ = MainWindow.Connectip.Replace("\n", ":") + MainWindow.Connectport;
							}
							catch
							{
							}
							_ = MainWindow.Connectip + ":" + MainWindow.Connectport;
							num = 9;
							num2 = num;
							continue;
						case 12:
						case 16:
							num = 3;
							num2 = num;
							continue;
						case 3:
							goto end_IL_0028;
							IL_0211:
							MainWindow.Mod_in = (string)mod_in;
							num = 1;
							num2 = num;
							continue;
							IL_00bd:
							num = 7;
							num2 = num;
							continue;
						}
						goto case 0;
						continue;
						end_IL_0028:
						break;
					}
					break;
				}
				case 0:
					MainWindow.CheckGameMods = false;
					MainWindow.IfStopedUload = true;
					num = 6;
					num2 = num;
					goto default;
				}
				break;
			}
		}
		catch
		{
			if (MainWindow.Langve == "RU")
			{
				MessageBoxWindow.Show(this, "Вы не выбрали сервер.", MainWindow.name_messege);
			}
			else
			{
				MessageBoxWindow.Show(this, "You did not select a server.", MainWindow.name_messege);
			}
		}
		num = 0;
		_ = num;
	}

	private void eval_b(object A_0, MouseEventArgs A_1)
	{
		short num = 13434;
		short num2 = num;
		num = 13434;
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
		num = 0;
		_ = num;
		BORDER.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7C7C7C"));
	}

	private void eval_a(object A_0, MouseEventArgs A_1)
	{
		short num = -15086;
		short num2 = num;
		num = -15086;
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
		num = 0;
		_ = num;
		BORDER.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF232323"));
	}

	private void eval_d(object A_0, MouseButtonEventArgs A_1)
	{
		short num;
		try
		{
			num = 30224;
			short num2 = num;
			num = 30224;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				Process.Start(LDISCORD);
				break;
			}
		}
		catch
		{
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		_ = num;
	}

	private void eval_c(object A_0, MouseButtonEventArgs A_1)
	{
		short num = 4;
		int num2 = num;
		MainWindow mainWindow = default(MainWindow);
		while (true)
		{
			switch (num2)
			{
			case 4:
				switch (0)
				{
				default:
					goto end_IL_0020;
				case 0:
					break;
				}
				goto default;
			default:
				mainWindow = Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
				{
					short num4 = 6449;
					short num5 = num4;
					num4 = 6449;
					switch (num5 == num4)
					{
					default:
						num4 = 0;
						if (num4 != 0)
						{
						}
						num4 = 1;
						if (num4 != 0)
						{
						}
						num4 = 0;
						_ = num4;
						return A_0 is MainWindow;
					}
				}) as MainWindow;
				num = 0;
				num2 = num;
				break;
			case 1:
				num = 0;
				_ = num;
				num = 1;
				if (num != 0)
				{
				}
				mainWindow.ShopGenerateUrl(LIp_Host_, LPort_host_);
				num = 2;
				num2 = num;
				break;
			case 2:
				if (mainWindow.f8.Visibility == Visibility.Hidden)
				{
					num = 5;
					num2 = num;
					break;
				}
				return;
			case 5:
			{
				num = -9322;
				short num3 = num;
				num = -9322;
				switch (num3 == num)
				{
				default:
				{
					num = 0;
					if (num != 0)
					{
					}
					mainWindow.eval_f9.Visibility = Visibility.Visible;
					mainWindow.f8.Visibility = Visibility.Visible;
					DoubleAnimation animation = new DoubleAnimation
					{
						From = 0.0,
						To = 1.0,
						Duration = new Duration(TimeSpan.FromSeconds(0.2)),
						AutoReverse = false
					};
					mainWindow.f8.BeginAnimation(UIElement.OpacityProperty, animation);
					num = 3;
					num2 = num;
					goto end_IL_0020;
				}
				case false:
				case true:
					break;
				}
				goto IL_017a;
			}
			case 0:
				if (!MainWindow.Enable_Shop)
				{
					return;
				}
				goto IL_017a;
			case 3:
				return;
				IL_017a:
				num = 1;
				num2 = num;
				break;
				end_IL_0020:
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(eval_b))]
	private void eval_b(object A_0, MouseButtonEventArgs A_1)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = -24695;
		short num2 = num;
		num = -24695;
		switch (num2 == num)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		num = 0;
		_ = num;
		eval_b stateMachine = default(eval_b);
		stateMachine.eval_b = AsyncVoidMethodBuilder.Create();
		stateMachine.eval_c = this;
		stateMachine.eval_a = -1;
		stateMachine.eval_b.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(eval_a))]
	private void eval_a(object A_0, MouseButtonEventArgs A_1)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 26464;
		short num2 = num;
		num = 26464;
		switch (num2 == num)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		num = 0;
		_ = num;
		eval_a stateMachine = default(eval_a);
		stateMachine.eval_b = AsyncVoidMethodBuilder.Create();
		stateMachine.eval_c = this;
		stateMachine.eval_a = -1;
		stateMachine.eval_b.Start(ref stateMachine);
	}
}
