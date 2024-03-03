using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Torrentific.Core.Models;

public class TorrentFileEntity : INotifyPropertyChanged
{
	private bool m_eval_a;

	private string b;

	private double eval_c;

	private string eval_d;

	private string e;

	[CompilerGenerated]
	private long eval_f;

	[CompilerGenerated]
	private string eval_g;

	[CompilerGenerated]
	private Guid eval_h;

	private string eval_i;

	[CompilerGenerated]
	private PropertyChangedEventHandler eval_j;

	public long Length
	{
		[CompilerGenerated]
		get
		{
			short num = -24599;
			short num2 = num;
			num = -24599;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			return eval_f;
		}
		[CompilerGenerated]
		set
		{
			short num = 5107;
			short num2 = num;
			num = 5107;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			eval_f = value;
		}
	}

	public string Path
	{
		[CompilerGenerated]
		get
		{
			short num = -21026;
			short num2 = num;
			num = -21026;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			return eval_g;
		}
		[CompilerGenerated]
		set
		{
			short num = -15333;
			short num2 = num;
			num = -15333;
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
			num = 1;
			if (num != 0)
			{
			}
			eval_g = value;
		}
	}

	public string Name
	{
		get
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			num = -12858;
			short num2 = num;
			num = -12858;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				return b;
			}
		}
		set
		{
			short num = 31221;
			short num2 = num;
			num = 31221;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			b = value;
			eval_a("Name");
		}
	}

	public string Size
	{
		get
		{
			short num = -19048;
			short num2 = num;
			num = -19048;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			return e;
		}
		set
		{
			short num = -11311;
			short num2 = num;
			num = -11311;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			e = value;
			eval_a("Size");
		}
	}

	public bool IsSelected
	{
		get
		{
			short num = 1379;
			short num2 = num;
			num = 1379;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			return this.m_eval_a;
		}
		set
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			num = -2162;
			short num2 = num;
			num = -2162;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			this.m_eval_a = value;
			eval_a("IsSelected");
		}
	}

	public double Progress
	{
		get
		{
			short num = 11403;
			short num2 = num;
			num = 11403;
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
			num = 1;
			if (num != 0)
			{
			}
			return eval_c;
		}
		set
		{
			short num = 10128;
			short num2 = num;
			num = 10128;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			eval_c = value;
			eval_a("Progress");
		}
	}

	public string ProgressText
	{
		get
		{
			short num = 14091;
			short num2 = num;
			num = 14091;
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
			num = 1;
			if (num != 0)
			{
			}
			return eval_d;
		}
		set
		{
			short num = 30696;
			short num2 = num;
			num = 30696;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			eval_d = value;
			eval_a("ProgressText");
		}
	}

	public string PriorityText
	{
		get
		{
			short num = -3897;
			short num2 = num;
			num = -3897;
			switch (num2 == num)
			{
			default:
				num = 0;
				_ = num;
				break;
			case true:
				break;
			}
			num = 1;
			if (num != 0)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			return eval_i;
		}
		set
		{
			short num = -1710;
			short num2 = num;
			num = -1710;
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
			num = 1;
			if (num != 0)
			{
			}
			eval_i = value;
			eval_a("PriorityText");
		}
	}

	public Guid Id
	{
		[CompilerGenerated]
		get
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			num = -25769;
			short num2 = num;
			num = -25769;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				return eval_h;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = -27;
			short num2 = num;
			num = -27;
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
			num = 1;
			if (num != 0)
			{
			}
			eval_h = value;
		}
	}

	public event PropertyChangedEventHandler PropertyChanged
	{
		[CompilerGenerated]
		add
		{
			int num3 = default(int);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			short num;
			switch (0)
			{
			default:
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
				while (true)
				{
					num = 19402;
					short num2 = num;
					num = 19402;
					switch (num2 == num)
					{
					case false:
					case true:
						goto end_IL_000a;
					}
					num = 0;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Combine(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref eval_j, value2, propertyChangedEventHandler2);
						num = 1;
						num3 = num;
						continue;
					}
					case 1:
						if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = 0;
							_ = num;
							num = 2;
							num3 = num;
							continue;
						}
						goto case 0;
					case 2:
						num = 1;
						if (num == 0)
						{
						}
						return;
					}
					goto case 0;
					continue;
					end_IL_000a:
					break;
				}
				goto IL_006d;
			}
			case 0:
				{
					propertyChangedEventHandler = eval_j;
					goto IL_006d;
				}
				IL_006d:
				num = 0;
				num3 = num;
				goto default;
			}
		}
		[CompilerGenerated]
		remove
		{
			int num3 = default(int);
			PropertyChangedEventHandler propertyChangedEventHandler = default(PropertyChangedEventHandler);
			short num;
			switch (0)
			{
			default:
			{
				PropertyChangedEventHandler propertyChangedEventHandler2 = default(PropertyChangedEventHandler);
				while (true)
				{
					num = -15864;
					short num2 = num;
					num = -15864;
					switch (num2 == num)
					{
					case false:
					case true:
						goto end_IL_000a;
					}
					num = 0;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
					{
						propertyChangedEventHandler2 = propertyChangedEventHandler;
						PropertyChangedEventHandler value2 = (PropertyChangedEventHandler)Delegate.Remove(propertyChangedEventHandler2, value);
						propertyChangedEventHandler = Interlocked.CompareExchange(ref eval_j, value2, propertyChangedEventHandler2);
						num = 1;
						num3 = num;
						continue;
					}
					case 1:
						if ((object)propertyChangedEventHandler == propertyChangedEventHandler2)
						{
							num = 0;
							_ = num;
							num = 2;
							num3 = num;
							continue;
						}
						goto case 0;
					case 2:
						num = 1;
						if (num == 0)
						{
						}
						return;
					}
					goto case 0;
					continue;
					end_IL_000a:
					break;
				}
				goto IL_006e;
			}
			case 0:
				{
					propertyChangedEventHandler = eval_j;
					goto IL_006e;
				}
				IL_006e:
				num = 0;
				num3 = num;
				goto default;
			}
		}
	}

	private void eval_a([CallerMemberName] string A_0 = null)
	{
		short num = 17542;
		short num2 = num;
		num = 17542;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			break;
		case true:
			break;
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		eval_j?.Invoke(this, new PropertyChangedEventArgs(A_0));
	}
}
