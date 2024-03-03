using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace ClientSample;

public class Top10Listener : TraceListener
{
	private readonly int eval_a;

	private readonly LinkedList<string> eval_b;

	public Top10Listener(int capacity)
	{
		eval_a = capacity;
		eval_b = new LinkedList<string>();
	}

	public override void Write(string message)
	{
		short num = 2940;
		short num2 = num;
		num = 2940;
		switch (num2 == num)
		{
		case false:
		case true:
			return;
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
		LinkedList<string> obj = eval_b;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			eval_b.Last.Value += message;
		}
		finally
		{
			num = 1;
			int num3 = num;
			while (true)
			{
				switch (num3)
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
					if (lockTaken)
					{
						num = 2;
						num3 = num;
						continue;
					}
					break;
				case 2:
					Monitor.Exit(obj);
					num = 0;
					num3 = num;
					continue;
				case 0:
					break;
				}
				break;
			}
		}
	}

	public override void WriteLine(string message)
	{
		short num = -11874;
		short num2 = num;
		num = -11874;
		switch (num2 == num)
		{
		default:
		{
			num = 0;
			if (num != 0)
			{
			}
			LinkedList<string> obj = eval_b;
			bool lockTaken = false;
			try
			{
				int num3 = default(int);
				switch (0)
				{
				default:
					while (true)
					{
						switch (num3)
						{
						case 2:
							if (eval_b.Count >= eval_a)
							{
								num = 1;
								num3 = num;
								continue;
							}
							goto case 3;
						case 1:
							eval_b.RemoveFirst();
							num = 3;
							num3 = num;
							continue;
						case 3:
							eval_b.AddLast(message);
							num = 0;
							num3 = num;
							continue;
						case 0:
							goto end_IL_005f;
						}
						goto case 0;
						continue;
						end_IL_005f:
						break;
					}
					break;
				case 0:
					Monitor.Enter(obj, ref lockTaken);
					num = 2;
					num3 = num;
					goto default;
				}
			}
			finally
			{
				num = 1;
				if (num != 0)
				{
				}
				num = 1;
				int num3 = num;
				while (true)
				{
					switch (num3)
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
						if (lockTaken)
						{
							num = 2;
							num3 = num;
							continue;
						}
						break;
					case 2:
						Monitor.Exit(obj);
						num = 0;
						num3 = num;
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			break;
		}
		case false:
		case true:
			break;
		}
		num = 0;
		_ = num;
	}

	public void ExportTo(TextWriter output)
	{
		while (true)
		{
			short num = 0;
			switch (num)
			{
			}
			num = 1;
			if (num != 0)
			{
			}
			LinkedList<string> obj = eval_b;
			bool lockTaken = false;
			try
			{
				Monitor.Enter(obj, ref lockTaken);
				using LinkedList<string>.Enumerator enumerator = eval_b.GetEnumerator();
				num = 3;
				int num2 = num;
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
						num = 4;
						num2 = num;
						continue;
					case 4:
						if (enumerator.MoveNext())
						{
							string current = enumerator.Current;
							output.WriteLine(current);
							num = 2;
							num2 = num;
						}
						else
						{
							num = 1;
							num2 = num;
						}
						continue;
					case 1:
						num = 0;
						num2 = num;
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			finally
			{
				num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
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
						if (lockTaken)
						{
							num = 2;
							num2 = num;
							continue;
						}
						break;
					case 2:
						Monitor.Exit(obj);
						num = 0;
						num2 = num;
						continue;
					case 0:
						break;
					}
					break;
				}
			}
			num = 23941;
			short num3 = num;
			num = 23941;
			switch (num3 == num)
			{
			case false:
			case true:
				continue;
			}
			num = 0;
			_ = num;
			num = 0;
			if (num == 0)
			{
			}
			return;
		}
	}
}
