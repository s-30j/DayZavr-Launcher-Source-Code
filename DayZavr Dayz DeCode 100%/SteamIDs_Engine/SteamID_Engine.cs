using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace SteamIDs_Engine;

public class SteamID_Engine
{
	[CompilerGenerated]
	private string eval_a;

	[CompilerGenerated]
	private AuthIdType eval_b;

	[CompilerGenerated]
	private string eval_c;

	[CompilerGenerated]
	private string eval_d;

	[CompilerGenerated]
	private long eval_e;

	public string WorkingID
	{
		[CompilerGenerated]
		get
		{
			short num = -432;
			short num2 = num;
			num = -432;
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
				return eval_a;
			}
		}
		[CompilerGenerated]
		private set
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = -25662;
			short num2 = num;
			num = -25662;
			switch (num2 == num)
			{
			}
			num = 0;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			eval_a = value;
		}
	}

	public AuthIdType AuthType
	{
		[CompilerGenerated]
		get
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = -15883;
			short num2 = num;
			num = -15883;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				num = 0;
				_ = num;
				return eval_b;
			}
		}
		[CompilerGenerated]
		private set
		{
			short num = 15178;
			short num2 = num;
			num = 15178;
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
			eval_b = value;
		}
	}

	public string Steam2
	{
		[CompilerGenerated]
		get
		{
			short num = 29036;
			short num2 = num;
			num = 29036;
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
				return eval_c;
			}
		}
		[CompilerGenerated]
		private set
		{
			short num = 25857;
			short num2 = num;
			num = 25857;
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
			eval_c = value;
		}
	}

	public string Steam32
	{
		[CompilerGenerated]
		get
		{
			short num = 14859;
			short num2 = num;
			num = 14859;
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
				return eval_d;
			}
		}
		[CompilerGenerated]
		private set
		{
			short num = 30027;
			short num2 = num;
			num = 30027;
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
			eval_d = value;
		}
	}

	public long Steam64
	{
		[CompilerGenerated]
		get
		{
			short num = -18420;
			short num2 = num;
			num = -18420;
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
				return eval_e;
			}
		}
		[CompilerGenerated]
		private set
		{
			short num = -21663;
			short num2 = num;
			num = -21663;
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
			eval_e = value;
		}
	}

	public SteamID_Engine(string ID)
	{
		WorkingID = ID;
		if (Regex.IsMatch(WorkingID, "^STEAM_0:[0-1]:([0-9]{1,10})$"))
		{
			AuthType = AuthIdType.AuthId_Steam2;
			Steam2 = WorkingID;
			Steam32 = SteamIDConvert.Steam2ToSteam32(WorkingID);
			Steam64 = SteamIDConvert.Steam2ToSteam64(WorkingID);
		}
		else if (!Regex.IsMatch(WorkingID, "^U:1:([0-9]{1,10})$"))
		{
			if (Regex.IsMatch(WorkingID, "^7656119([0-9]{10})$"))
			{
				AuthType = AuthIdType.AuthId_SteamID64;
				Steam2 = SteamIDConvert.Steam64ToSteam2(long.Parse(WorkingID));
				Steam32 = SteamIDConvert.Steam64ToSteam32(long.Parse(WorkingID));
				Steam64 = long.Parse(WorkingID);
			}
			else
			{
				AuthType = AuthIdType.AuthId_Engine;
			}
		}
		else
		{
			AuthType = AuthIdType.AuthId_Steam3;
			Steam2 = SteamIDConvert.Steam32ToSteam2(WorkingID);
			Steam32 = WorkingID;
			Steam64 = SteamIDConvert.Steam32ToSteam64(WorkingID);
		}
	}

	public string AuthType_string()
	{
		short num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				switch (0)
				{
				default:
					goto end_IL_001f;
				case 0:
					break;
				}
				goto default;
			default:
				if (AuthType == AuthIdType.AuthId_Steam2)
				{
					num = 4;
					num2 = num;
				}
				else
				{
					num = 2;
					num2 = num;
				}
				break;
			case 6:
				if (AuthType == AuthIdType.AuthId_SteamID64)
				{
					num = 0;
					num2 = num;
				}
				else
				{
					num = 7;
					num2 = num;
				}
				break;
			case 0:
				num = 1;
				if (num != 0)
				{
				}
				return "SteamID64";
			case 2:
				num = 0;
				_ = num;
				if (AuthType != AuthIdType.AuthId_Steam3)
				{
					num = 6;
					num2 = num;
				}
				else
				{
					num = 5;
					num2 = num;
				}
				break;
			case 1:
				return "Engine ID";
			case 4:
			{
				num = -22142;
				short num3 = num;
				num = -22142;
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
					return "SteamID2";
				}
				goto case 1;
			}
			case 7:
				if (AuthType == AuthIdType.AuthId_Engine)
				{
					num = 1;
					num2 = num;
					break;
				}
				return string.Empty;
			case 5:
				{
					return "SteamID32";
				}
				end_IL_001f:
				break;
			}
		}
	}
}
