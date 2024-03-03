using System;
using System.Diagnostics;

public static class FireWall
{
	public static string ProgramName;

	public static bool AllowThisProgram(string Protocol, string RemotePorts, string LocalPorts, string Direction)
	{
		int num = default(int);
		string programName = default(string);
		string text = default(string);
		int num2 = default(int);
		switch (0)
		{
		default:
			while (true)
			{
				switch (num)
				{
				case 0:
				{
					short num3 = 1;
					if (num3 != 0)
					{
					}
					if (ProgramName.Length == 0)
					{
						num3 = 1;
						num = num3;
						continue;
					}
					goto case 2;
				}
				case 1:
				{
					programName = text.Substring(num2 + 1);
					short num3 = 1276;
					short num4 = num3;
					num3 = 1276;
					switch (num4 == num3)
					{
					default:
						num3 = 0;
						if (num3 != 0)
						{
						}
						num3 = 2;
						num = num3;
						continue;
					case false:
					case true:
						break;
					}
					goto case 2;
				}
				case 2:
					return AllowProgram(programName, text, Protocol, RemotePorts, LocalPorts, Direction);
				}
				break;
			}
			goto case 0;
		case 0:
		{
			short num3 = 0;
			_ = num3;
			text = AppDomain.CurrentDomain.BaseDirectory + AppDomain.CurrentDomain.FriendlyName;
			num2 = text.LastIndexOf("\\");
			programName = ProgramName;
			num3 = 0;
			num = num3;
			goto default;
		}
		}
	}

	public static bool AllowProgram(string programName, string ProgramFileName, string Protocol, string RemotePorts, string LocalPorts, string Direction)
	{
		int num = default(int);
		string text2 = default(string);
		switch (0)
		{
		default:
		{
			string text = default(string);
			while (true)
			{
				switch (num)
				{
				case 13:
					if (LocalPorts.Length > 0)
					{
						short num2 = 7;
						num = num2;
						continue;
					}
					goto case 2;
				case 10:
				{
					text2 = text2 + " remoteport=\"" + RemotePorts + "\"";
					short num2 = 6;
					num = num2;
					continue;
				}
				case 5:
				case 20:
				{
					short num2 = 3;
					num = num2;
					continue;
				}
				case 3:
					if (ProgramFileName.Length > 0)
					{
						short num2 = 19;
						num = num2;
					}
					else
					{
						ProgramFileName = "Any";
						short num2 = 14;
						num = num2;
					}
					continue;
				case 19:
				{
					short num2 = 1;
					if (num2 != 0)
					{
					}
					text = text + " program=\"" + ProgramFileName + "\"";
					num2 = 16;
					num = num2;
					continue;
				}
				case 2:
				{
					short num2 = 1;
					num = num2;
					continue;
				}
				case 1:
					if (RemotePorts.Length > 0)
					{
						short num2 = 10;
						num = num2;
						continue;
					}
					goto case 6;
				case 0:
				{
					text = text + " localport=\"" + LocalPorts + "\"";
					short num2 = 4;
					num = num2;
					continue;
				}
				case 6:
				{
					short num2 = 8;
					num = num2;
					continue;
				}
				case 8:
					if (ProgramFileName.Length > 0)
					{
						short num2 = 9;
						num = num2;
						continue;
					}
					goto case 11;
				case 4:
				case 12:
				{
					short num2 = 15;
					num = num2;
					continue;
				}
				case 15:
					if (RemotePorts.Length <= 0)
					{
						RemotePorts = "Any";
						short num2 = 5;
						num = num2;
					}
					else
					{
						short num2 = 17;
						num = num2;
					}
					continue;
				case 17:
				{
					short num2 = 23286;
					short num3 = num2;
					num2 = 23286;
					switch (num3 == num2)
					{
					case false:
					case true:
						break;
					default:
						num2 = 0;
						if (num2 != 0)
						{
						}
						text = text + " remoteport=\"" + RemotePorts + "\"";
						num2 = 20;
						num = num2;
						continue;
					}
					goto case 19;
				}
				case 9:
				{
					text2 = text2 + " program=\"" + ProgramFileName + "\"";
					short num2 = 11;
					num = num2;
					continue;
				}
				case 7:
				{
					text2 = text2 + " localport=\"" + LocalPorts + "\"";
					short num2 = 2;
					num = num2;
					continue;
				}
				case 11:
				{
					ExecuteCommandAsAdmin(text2);
					text = "netsh advfirewall firewall add rule name='" + programName + "' dir=" + Direction.ToLower() + " action=allow protocol=" + Protocol.ToUpper();
					short num2 = 18;
					num = num2;
					continue;
				}
				case 18:
					if (LocalPorts.Length <= 0)
					{
						LocalPorts = "Any";
						short num2 = 12;
						num = num2;
					}
					else
					{
						short num2 = 0;
						num = num2;
					}
					continue;
				case 14:
				case 16:
					text = text + " description='Allow " + ProgramFileName + " on " + Protocol + " using local-ports " + LocalPorts + " and remote-ports " + RemotePorts + "'";
					return ExecuteCommandAsAdmin(text).ToUpper().StartsWith("OK");
				}
				break;
			}
			goto case 0;
		}
		case 0:
		{
			short num2 = 0;
			_ = num2;
			programName = "Allow " + programName + " " + Protocol.ToUpper() + " " + Direction.ToLower() + " " + LocalPorts + " " + RemotePorts;
			programName = programName.Replace("  ", " ").Trim();
			text2 = "netsh advfirewall firewall delete rule name='" + programName + "' protocol=" + Protocol.ToUpper() + " dir=" + Direction.ToLower();
			num2 = 13;
			num = num2;
			goto default;
		}
		}
	}

	public static string ExecuteCommandAsAdmin(string command)
	{
		string result = default(string);
		short num;
		try
		{
			num = -29831;
			short num2 = num;
			num = -29831;
			int num3 = default(int);
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				num = 0;
				num3 = num;
				switch (num3)
				{
				}
				break;
			case false:
			case true:
				break;
			}
			ProcessStartInfo startInfo = new ProcessStartInfo
			{
				FileName = "powershell.exe",
				Arguments = command,
				RedirectStandardError = true,
				RedirectStandardOutput = true,
				UseShellExecute = false,
				WindowStyle = ProcessWindowStyle.Hidden
			};
			Process process = new Process();
			try
			{
				string text = default(string);
				switch (0)
				{
				default:
					while (true)
					{
						switch (num3)
						{
						case 0:
							if (string.IsNullOrEmpty(text))
							{
								num = 1;
								num3 = num;
								continue;
							}
							goto case 2;
						case 1:
							text = process.StandardError.ReadToEnd();
							num = 2;
							num3 = num;
							continue;
						case 2:
							result = text;
							num = 3;
							num3 = num;
							continue;
						case 3:
							goto end_IL_00b0;
						}
						goto case 0;
						continue;
						end_IL_00b0:
						break;
					}
					break;
				case 0:
					process.StartInfo = startInfo;
					process.Start();
					text = process.StandardOutput.ReadToEnd();
					num = 0;
					num3 = num;
					goto default;
				}
			}
			finally
			{
				num = 0;
				num3 = num;
				while (true)
				{
					switch (num3)
					{
					case 0:
						switch (0)
						{
						default:
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						if (process != null)
						{
							num = 1;
							num3 = num;
							continue;
						}
						break;
					case 1:
						((IDisposable)process).Dispose();
						num = 2;
						num3 = num;
						continue;
					case 2:
						break;
					}
					break;
				}
			}
		}
		catch (Exception ex)
		{
			string text = "ERROR," + ex.Message;
			result = text;
		}
		num = 0;
		_ = num;
		num = 1;
		if (num != 0)
		{
		}
		return result;
	}

	static FireWall()
	{
		short num = 15645;
		short num2 = num;
		num = 15645;
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
		ProgramName = "";
	}
}
