using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace SingleInstance;

public class SingleApplication
{
	private static Mutex a;

	private const int m_eval_b = 9;

	[DllImport("user32.dll")]
	private static extern int ShowWindow(IntPtr A_0, int A_1);

	[DllImport("user32.dll")]
	private static extern int SetForegroundWindow(IntPtr A_0);

	[DllImport("user32.dll")]
	private static extern int IsIconic(IntPtr A_0);

	private static IntPtr eval_c()
	{
		short num = 0;
		int num2 = num;
		switch (num2)
		{
		default:
		{
			Process currentProcess = default(Process);
			int num4 = default(int);
			Process[] processesByName = default(Process[]);
			IntPtr result = default(IntPtr);
			switch (0)
			{
			default:
			{
				Process process = default(Process);
				while (true)
				{
					switch (num2)
					{
					case 0:
						num = 7;
						num2 = num;
						continue;
					case 7:
					{
						num = 30088;
						short num3 = num;
						num = 30088;
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
							goto IL_013d;
						case false:
						case true:
							break;
						}
						goto IL_027f;
					}
					case 2:
						num = 1;
						if (num != 0)
						{
						}
						if (process.Id != currentProcess.Id)
						{
							num = 4;
							num2 = num;
							continue;
						}
						goto IL_008f;
					case 1:
					case 6:
						num = 3;
						num2 = num;
						continue;
					case 3:
						if (num4 < processesByName.Length)
						{
							process = processesByName[num4];
							num = 2;
							num2 = num;
						}
						else
						{
							num = 8;
							num2 = num;
						}
						continue;
					case 4:
						num = 10;
						num2 = num;
						continue;
					case 10:
						if (process.MainModule.FileName == currentProcess.MainModule.FileName)
						{
							num = 0;
							num2 = num;
							continue;
						}
						goto IL_008f;
					case 9:
						result = process.MainWindowHandle;
						goto IL_027f;
					case 5:
					case 8:
						{
							return result;
						}
						IL_027f:
						num = 5;
						num2 = num;
						continue;
						IL_013d:
						if (process.MainWindowHandle != IntPtr.Zero)
						{
							num = 9;
							num2 = num;
							continue;
						}
						goto IL_008f;
						IL_008f:
						num4++;
						num = 1;
						num2 = num;
						continue;
					}
					break;
				}
				goto case 0;
			}
			case 0:
				result = IntPtr.Zero;
				currentProcess = Process.GetCurrentProcess();
				processesByName = Process.GetProcessesByName(currentProcess.ProcessName);
				num4 = 0;
				num = 6;
				num2 = num;
				goto default;
			}
		}
		}
	}

	private static void eval_b()
	{
		int num2 = default(int);
		IntPtr intPtr = default(IntPtr);
		switch (0)
		{
		default:
			while (true)
			{
				short num = 1;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 2:
					if (!(intPtr != IntPtr.Zero))
					{
						return;
					}
					goto IL_0079;
				case 3:
				{
					SetForegroundWindow(intPtr);
					num = -12973;
					short num3 = num;
					num = -12973;
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
						num = 1;
						num2 = num;
						continue;
					}
					goto IL_0079;
				}
				case 1:
					return;
				case 0:
					ShowWindow(intPtr, 9);
					num = 3;
					num2 = num;
					continue;
				case 4:
					num = 5;
					num2 = num;
					continue;
				case 5:
					{
						if (IsIconic(intPtr) != 0)
						{
							num = 0;
							_ = num;
							num = 0;
							num2 = num;
							continue;
						}
						goto case 3;
					}
					IL_0079:
					num = 4;
					num2 = num;
					continue;
				}
				break;
			}
			goto case 0;
		case 0:
		{
			intPtr = eval_c();
			short num = 2;
			num2 = num;
			goto default;
		}
		}
	}

	public static bool Run(Form frmMain)
	{
		short num = 1;
		if (num != 0)
		{
		}
		if (eval_a())
		{
			num = 0;
			_ = num;
			num = 32119;
			short num2 = num;
			num = 32119;
			switch (num2 == num)
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
			eval_b();
			return false;
		}
		Application.Run(frmMain);
		return true;
	}

	public static bool Run()
	{
		short num = 1;
		if (num != 0)
		{
		}
		if (eval_a())
		{
			num = 0;
			_ = num;
			num = -8120;
			short num2 = num;
			num = -8120;
			switch (num2 == num)
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
			return false;
		}
		return true;
	}

	private static bool eval_a()
	{
		int num = default(int);
		bool createdNew = default(bool);
		switch (0)
		{
		default:
			while (true)
			{
				short num2;
				switch (num)
				{
				case 2:
				{
					num2 = -26335;
					short num3 = num2;
					num2 = -26335;
					switch (num3 == num2)
					{
					case false:
					case true:
						goto IL_00ed;
					}
					num2 = 0;
					if (num2 != 0)
					{
					}
					num2 = 1;
					if (num2 != 0)
					{
					}
					if (createdNew)
					{
						num2 = 0;
						num = num2;
						continue;
					}
					goto case 1;
				}
				case 0:
					goto IL_00ed;
				case 1:
					{
						return !createdNew;
					}
					IL_00ed:
					a.ReleaseMutex();
					num2 = 0;
					_ = num2;
					num2 = 1;
					num = num2;
					continue;
				}
				break;
			}
			goto case 0;
		case 0:
		{
			string name = new FileInfo(Assembly.GetExecutingAssembly().Location).Name;
			a = new Mutex(initiallyOwned: true, "Global\\" + name, out createdNew);
			short num2 = 2;
			num = num2;
			goto default;
		}
		}
	}
}
