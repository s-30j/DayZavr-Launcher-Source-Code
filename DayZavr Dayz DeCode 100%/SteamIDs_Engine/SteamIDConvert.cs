using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace SteamIDs_Engine;

public static class SteamIDConvert
{
	public static string Steam32ToSteam2(string input)
	{
		short num = 18;
		short num2 = num;
		num = 18;
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
			if (!Regex.IsMatch(input, "^U:1:([0-9]{1,10})$"))
			{
				goto case false;
			}
			return Steam64ToSteam2(Steam32ToSteam64(input));
		case false:
		case true:
			return string.Empty;
		}
	}

	public static string Steam2ToSteam32(string input)
	{
		short num = 19528;
		short num2 = num;
		num = 19528;
		switch (num2 == num)
		{
		default:
			num = 0;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			if (!Regex.IsMatch(input, "^STEAM_0:[0-1]:([0-9]{1,10})$"))
			{
				num = 1;
				if (num == 0)
				{
				}
				goto case false;
			}
			return Steam64ToSteam32(Steam2ToSteam64(input));
		case false:
		case true:
			return string.Empty;
		}
	}

	public static long Steam32ToSteam64(string input)
	{
		int num3 = default(int);
		long num4 = default(long);
		switch (0)
		{
		default:
			while (true)
			{
				short num = -10759;
				short num2 = num;
				num = -10759;
				switch (num2 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						if (num4 >= 1)
						{
							goto IL_0093;
						}
						goto IL_00ad;
					case 2:
						goto IL_00c5;
					case 1:
						goto IL_00ef;
					case 3:
						{
							num = 1;
							if (num == 0)
							{
							}
							goto IL_00ad;
						}
						IL_00ad:
						return 0L;
					}
					break;
				case false:
				case true:
					goto IL_0093;
					IL_0093:
					num = 2;
					num3 = num;
					continue;
					IL_00ef:
					if (!Regex.IsMatch("U:1:" + num4.ToString(CultureInfo.InvariantCulture), "^U:1:([0-9]{1,10})$"))
					{
						num = 3;
						num3 = num;
						continue;
					}
					return num4 + 76561197960265728L;
					IL_00c5:
					num = 0;
					_ = num;
					num = 1;
					num3 = num;
					continue;
				}
				break;
			}
			goto case 0;
		case 0:
		{
			num4 = Convert.ToInt64(input.Substring(4));
			short num = 0;
			num3 = num;
			goto default;
		}
		}
	}

	public static string Steam64ToSteam2(long communityId)
	{
		short num = 2;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				num = 1;
				if (num != 0)
				{
				}
				switch (0)
				{
				default:
					goto end_IL_0046;
				case 0:
					break;
				}
				goto default;
			default:
				if (communityId >= 76561197960265729L)
				{
					num = 4;
					num2 = num;
					break;
				}
				goto IL_0148;
			case 1:
			{
				num = -30862;
				short num4 = num;
				num = -30862;
				switch (num4 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					if (!Regex.IsMatch(text, "^STEAM_0:[0-1]:([0-9]{1,10})$"))
					{
						num = 3;
						num2 = num;
						goto end_IL_0046;
					}
					return text;
				case false:
				case true:
					break;
				}
				goto case 4;
			}
			case 4:
				num = 5;
				num2 = num;
				break;
			case 5:
				if (Regex.IsMatch(communityId.ToString(CultureInfo.InvariantCulture), "^7656119([0-9]{10})$"))
				{
					communityId -= 76561197960265728L;
					long num3 = communityId % 2;
					communityId -= num3;
					text = $"STEAM_0:{num3}:{communityId / 2}";
					num = 1;
					num2 = num;
				}
				else
				{
					num = 0;
					num2 = num;
				}
				break;
			case 0:
				num = 0;
				_ = num;
				goto IL_0148;
			case 3:
				{
					return string.Empty;
				}
				IL_0148:
				return string.Empty;
				end_IL_0046:
				break;
			}
		}
	}

	public static long Steam2ToSteam64(string accountId)
	{
		short num = 21949;
		short num2 = num;
		num = 21949;
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
			if (!Regex.IsMatch(accountId, "^STEAM_0:[0-1]:([0-9]{1,10})$"))
			{
				goto case false;
			}
			return 76561197960265728L + Convert.ToInt64(accountId.Substring(10)) * 2 + Convert.ToInt64(accountId.Substring(8, 1));
		case false:
		case true:
			return 0L;
		}
	}

	public static string Steam64ToSteam32(long communityId)
	{
		short num = 0;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 0:
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
				if (communityId >= 76561197960265729L)
				{
					num = 2;
					num2 = num;
					break;
				}
				goto IL_007d;
			case 2:
				num = 0;
				_ = num;
				num = 1;
				num2 = num;
				break;
			case 1:
				if (!Regex.IsMatch(communityId.ToString(CultureInfo.InvariantCulture), "^7656119([0-9]{10})$"))
				{
					num = 3;
					num2 = num;
					break;
				}
				return $"U:1:{communityId - 76561197960265728L}";
			case 3:
				{
					num = -905;
					short num3 = num;
					num = -905;
					switch (num3 == num)
					{
					case false:
					case true:
						break;
					default:
						goto IL_0128;
					}
					goto case 0;
				}
				IL_0128:
				num = 0;
				if (num == 0)
				{
				}
				goto IL_007d;
				IL_007d:
				return string.Empty;
				end_IL_0020:
				break;
			}
		}
	}
}
