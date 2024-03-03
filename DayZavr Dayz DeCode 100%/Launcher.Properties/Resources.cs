using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace Launcher.Properties;

[DebuggerNonUserCode]
[CompilerGenerated]
[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "17.0.0.0")]
internal class Resources
{
	private static ResourceManager eval_a;

	private static CultureInfo eval_b;

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static ResourceManager ResourceManager
	{
		get
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
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					if (eval_a != null)
					{
						break;
					}
					goto IL_003a;
				case 0:
					num = 0;
					_ = num;
					eval_a = new ResourceManager("Launcher.Properties.Resources", typeof(Resources).Assembly);
					num = 2;
					num2 = num;
					continue;
				case 2:
					{
						num = 1;
						if (num != 0)
						{
						}
						num = -10800;
						short num3 = num;
						num = -10800;
						switch (num3 == num)
						{
						case false:
						case true:
							break;
						default:
							goto IL_010d;
						}
						goto IL_003a;
					}
					IL_003a:
					num = 0;
					num2 = num;
					continue;
					IL_010d:
					num = 0;
					if (num == 0)
					{
					}
					break;
				}
				break;
			}
			return eval_a;
		}
	}

	[EditorBrowsable(EditorBrowsableState.Advanced)]
	internal static CultureInfo Culture
	{
		get
		{
			short num = -22577;
			short num2 = num;
			num = -22577;
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
				return eval_b;
			}
		}
		set
		{
			short num = 2762;
			short num2 = num;
			num = 2762;
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
			eval_b = value;
		}
	}

	internal Resources()
	{
	}
}
