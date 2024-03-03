using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Xml;

namespace UPnP;

public class NAT
{
	[CompilerGenerated]
	private static TimeSpan m_eval_a;

	private static string eval_b;

	private static string eval_c;

	private static string eval_d;

	public static TimeSpan TimeOut
	{
		[CompilerGenerated]
		get
		{
			short num = 15480;
			short num2 = num;
			num = 15480;
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
				return NAT.m_eval_a;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 10887;
			short num2 = num;
			num = 10887;
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
			NAT.m_eval_a = value;
		}
	}

	public static bool Discover(int porteUtorrent)
	{
		short num = 0;
		int num2 = num;
		switch (num2)
		{
		default:
		{
			Socket socket = default(Socket);
			byte[] bytes = default(byte[]);
			IPEndPoint remoteEP = default(IPEndPoint);
			DateTime now = default(DateTime);
			byte[] array = default(byte[]);
			switch (0)
			{
			default:
			{
				int num4 = default(int);
				string text = default(string);
				while (true)
				{
					switch (num2)
					{
					case 4:
					{
						num = -29589;
						short num3 = num;
						num = -29589;
						switch (num3 == num)
						{
						case false:
						case true:
							goto IL_0311;
						}
						num = 0;
						if (num != 0)
						{
						}
						if (num4 <= 0)
						{
							num = 6;
							num2 = num;
							continue;
						}
						goto case 2;
					}
					case 3:
						text = text.Substring(text.ToLower().IndexOf("location:") + 9);
						text = text.Substring(0, text.IndexOf("\r")).Trim();
						num = 8;
						num2 = num;
						continue;
					case 8:
						if (!string.IsNullOrEmpty(eval_c = eval_a(text)))
						{
							num = 1;
							num2 = num;
							continue;
						}
						goto IL_00c2;
					case 5:
						num = 1;
						if (num != 0)
						{
						}
						socket.SendTo(bytes, remoteEP);
						socket.SendTo(bytes, remoteEP);
						socket.SendTo(bytes, remoteEP);
						num4 = 0;
						num = 2;
						num2 = num;
						continue;
					case 6:
						num = 7;
						num2 = num;
						continue;
					case 7:
						if (!(now.Subtract(DateTime.Now) < TimeOut))
						{
							num = 0;
							_ = num;
							num = 9;
							num2 = num;
							continue;
						}
						goto case 5;
					case 2:
						num4 = socket.Receive(array);
						text = Encoding.ASCII.GetString(array, 0, num4).ToLower();
						num = 0;
						num2 = num;
						continue;
					case 0:
						if (text.Contains("upnp:rootdevice"))
						{
							num = 3;
							num2 = num;
							continue;
						}
						goto IL_00c2;
					case 1:
						goto IL_0311;
					case 9:
						{
							return false;
						}
						IL_0311:
						eval_b = text;
						return true;
						IL_00c2:
						num = 4;
						num2 = num;
						continue;
					}
					break;
				}
				goto case 0;
			}
			case 0:
			{
				socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
				socket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.Broadcast, 1);
				string s = "M-SEARCH * HTTP/1.1\r\nHOST: 239.255.255.250:1900\r\nST:upnp:rootdevice\r\nMAN:\"ssdp:discover\"\r\nMX:3\r\n\r\n";
				bytes = Encoding.ASCII.GetBytes(s);
				remoteEP = new IPEndPoint(IPAddress.Broadcast, 1900);
				array = new byte[4096];
				now = DateTime.Now;
				num = 5;
				num2 = num;
				goto default;
			}
			}
		}
		}
	}

	private static string eval_a(string A_0)
	{
		string result = default(string);
		short num;
		try
		{
			num = 0;
			int num2 = num;
			switch (num2)
			{
			default:
			{
				XmlDocument xmlDocument = default(XmlDocument);
				XmlNamespaceManager xmlNamespaceManager = default(XmlNamespaceManager);
				switch (0)
				{
				default:
				{
					XmlNode xmlNode = default(XmlNode);
					while (true)
					{
						switch (num2)
						{
						case 2:
							if (!xmlDocument.SelectSingleNode("//tns:device/tns:deviceType/text()", xmlNamespaceManager).Value.Contains("InternetGatewayDevice"))
							{
								num = 3;
								num2 = num;
							}
							else
							{
								xmlNode = xmlDocument.SelectSingleNode("//tns:service[tns:serviceType=\"urn:schemas-upnp-org:service:WANIPConnection:1\"]/tns:controlURL/text()", xmlNamespaceManager);
								num = 0;
								num2 = num;
							}
							continue;
						case 4:
							result = null;
							num = 5;
							num2 = num;
							continue;
						case 5:
							goto end_IL_0027;
						case 0:
						{
							if (xmlNode == null)
							{
								num = 4;
								num2 = num;
								continue;
							}
							num = -26057;
							short num3 = num;
							num = -26057;
							switch (num3 == num)
							{
							case false:
							case true:
								break;
							default:
							{
								num = 0;
								if (num != 0)
								{
								}
								XmlNode xmlNode2 = xmlDocument.SelectSingleNode("//tns:service[tns:serviceType=\"urn:schemas-upnp-org:service:WANIPConnection:1\"]/tns:eventSubURL/text()", xmlNamespaceManager);
								eval_d = eval_a(A_0, xmlNode2.Value);
								result = eval_a(A_0, xmlNode.Value);
								num = 1;
								num2 = num;
								continue;
							}
							}
							goto case 4;
						}
						case 3:
							result = null;
							num = 6;
							num2 = num;
							continue;
						case 6:
							goto end_IL_0027;
						case 1:
							goto end_IL_0027;
						}
						goto case 0;
						continue;
						end_IL_0027:
						break;
					}
					break;
				}
				case 0:
					xmlDocument = new XmlDocument();
					xmlDocument.Load(WebRequest.Create(A_0).GetResponse().GetResponseStream());
					xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
					xmlNamespaceManager.AddNamespace("tns", "urn:schemas-upnp-org:device-1-0");
					num = 2;
					num2 = num;
					goto default;
				}
				break;
			}
			}
		}
		catch
		{
			result = null;
		}
		num = 0;
		_ = num;
		num = 1;
		if (num != 0)
		{
		}
		return result;
	}

	private static string eval_a(string A_0, string A_1)
	{
		short num = 10630;
		short num2 = num;
		num = 10630;
		switch (num2 == num)
		{
		default:
		{
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
			int num3 = A_0.IndexOf("://");
			num3 = A_0.IndexOf('/', num3 + 3);
			return A_0.Substring(0, num3) + A_1;
		}
		}
	}

	public static void ForwardPort(int port, ProtocolType protocol, string description)
	{
		short num = -28000;
		short num2 = num;
		num = -28000;
		switch (num2 == num)
		{
		default:
			num = 0;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			if (string.IsNullOrEmpty(eval_c))
			{
				num = 1;
				if (num == 0)
				{
				}
				goto case false;
			}
			eval_a(eval_c, "<u:AddPortMapping xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\"><NewRemoteHost></NewRemoteHost><NewExternalPort>" + port + "</NewExternalPort><NewProtocol>" + protocol.ToString().ToUpper() + "</NewProtocol><NewInternalPort>" + port + "</NewInternalPort><NewInternalClient>" + Dns.GetHostAddresses(Dns.GetHostName())[0].ToString() + "</NewInternalClient><NewEnabled>1</NewEnabled><NewPortMappingDescription>" + description + "</NewPortMappingDescription><NewLeaseDuration>0</NewLeaseDuration></u:AddPortMapping>", "AddPortMapping");
			break;
		case false:
		case true:
			throw new Exception("No UPnP service available or Discover() has not been called");
		}
	}

	public static void DeleteForwardingRule(int port, ProtocolType protocol)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 22708;
		short num2 = num;
		num = 22708;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			num = 0;
			if (num != 0)
			{
			}
			if (string.IsNullOrEmpty(eval_c))
			{
				goto case false;
			}
			eval_a(eval_c, "<u:DeletePortMapping xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\"><NewRemoteHost></NewRemoteHost><NewExternalPort>" + port + "</NewExternalPort><NewProtocol>" + protocol.ToString().ToUpper() + "</NewProtocol></u:DeletePortMapping>", "DeletePortMapping");
			break;
		case false:
		case true:
			throw new Exception("No UPnP service available or Discover() has not been called");
		}
	}

	public static IPAddress GetExternalIP()
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 20276;
		short num2 = num;
		num = 20276;
		switch (num2 == num)
		{
		default:
		{
			num = 0;
			_ = num;
			num = 0;
			if (num != 0)
			{
			}
			if (string.IsNullOrEmpty(eval_c))
			{
				goto case false;
			}
			XmlDocument xmlDocument = eval_a(eval_c, "<u:GetExternalIPAddress xmlns:u=\"urn:schemas-upnp-org:service:WANIPConnection:1\"></u:GetExternalIPAddress>", "GetExternalIPAddress");
			XmlNamespaceManager xmlNamespaceManager = new XmlNamespaceManager(xmlDocument.NameTable);
			xmlNamespaceManager.AddNamespace("tns", "urn:schemas-upnp-org:device-1-0");
			return IPAddress.Parse(xmlDocument.SelectSingleNode("//NewExternalIPAddress/text()", xmlNamespaceManager).Value);
		}
		case false:
		case true:
			throw new Exception("No UPnP service available or Discover() has not been called");
		}
	}

	private static XmlDocument eval_a(string A_0, string A_1, string A_2)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = -23293;
		short num2 = num;
		num = -23293;
		switch (num2 == num)
		{
		default:
		{
			num = 0;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			string s = "<?xml version=\"1.0\"?><s:Envelope xmlns:s=\"http://schemas.xmlsoap.org/soap/envelope/\" s:encodingStyle=\"http://schemas.xmlsoap.org/soap/encoding/\"><s:Body>" + A_1 + "</s:Body></s:Envelope>";
			WebRequest webRequest = WebRequest.Create(A_0);
			webRequest.Method = "POST";
			byte[] bytes = Encoding.UTF8.GetBytes(s);
			webRequest.Headers.Add("SOAPACTION", "\"urn:schemas-upnp-org:service:WANIPConnection:1#" + A_2 + "\"");
			webRequest.ContentType = "text/xml; charset=\"utf-8\"";
			webRequest.ContentLength = bytes.Length;
			webRequest.GetRequestStream().Write(bytes, 0, bytes.Length);
			XmlDocument xmlDocument = new XmlDocument();
			Stream responseStream = webRequest.GetResponse().GetResponseStream();
			xmlDocument.Load(responseStream);
			return xmlDocument;
		}
		}
	}

	static NAT()
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 7616;
		short num2 = num;
		num = 7616;
		switch (num2 == num)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		num = 0;
		_ = num;
		NAT.m_eval_a = new TimeSpan(0, 0, 0, 3);
	}
}
