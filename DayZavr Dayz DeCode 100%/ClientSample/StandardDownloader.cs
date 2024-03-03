using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Launcher;
using MonoTorrent;
using MonoTorrent.Client;
using MonoTorrent.PortForwarding;
using MonoTorrent.Trackers;

namespace ClientSample;

public class StandardDownloader
{
	public delegate void StatusMessageEventHandler(object sender, string message);

	public class FILERESUMETOTORRENT
	{
		[CompilerGenerated]
		private string eval_a;

		public string FILETOTORRENT
		{
			[CompilerGenerated]
			get
			{
				short num = -26825;
				short num2 = num;
				num = -26825;
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
					return eval_a;
				}
			}
			[CompilerGenerated]
			set
			{
				short num = -15614;
				short num2 = num;
				num = -15614;
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
				eval_a = value;
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct eval_a : IAsyncStateMachine
	{
		public int eval_a;

		public AsyncTaskMethodBuilder eval_b;

		public StandardDownloader eval_c;

		public string eval_d;

		public string eval_e;

		public bool eval_f;

		public bool eval_g;

		public bool eval_h;

		public List<string> eval_i;

		public bool eval_j;

		public string eval_k;

		public bool eval_l;

		public CancellationToken m;

		private MainWindow eval_n;

		private long eval_o;

		private bool eval_p;

		[global::eval_b(new byte[] { 0, 1 })]
		private TaskAwaiter<TorrentManager> eval_q;

		[global::eval_b(new byte[] { 0, 1 })]
		private IEnumerator<TorrentManager> eval_r;

		private TorrentManager eval_s;

		[global::eval_b(new byte[] { 0, 1 })]
		private IEnumerator<ITorrentManagerFile> eval_t;

		private TaskAwaiter eval_u;

		private bool eval_v;

		private bool eval_w;

		private string eval_x;

		private string eval_y;

		private TaskAwaiter<int> eval_z;

		private void eval_m()
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 0;
			switch (num)
			{
			}
			num = 2985;
			short num2 = num;
			num = 2985;
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
			num = 0;
			_ = num;
			int num3 = eval_a;
			StandardDownloader CS_0024_003C_003E8__locals0 = eval_c;
			try
			{
				num = 37;
				int num4 = num;
				TaskAwaiter<TorrentManager> awaiter = default(TaskAwaiter<TorrentManager>);
				TorrentManager result = default(TorrentManager);
				TaskAwaiter awaiter2 = default(TaskAwaiter);
				ITorrentManagerFile current3 = default(ITorrentManagerFile);
				bool flag5 = default(bool);
				int num8 = default(int);
				bool flag7 = default(bool);
				ITorrentManagerFile current5 = default(ITorrentManagerFile);
				IEnumerator<ITorrentManagerFile> enumerator = default(IEnumerator<ITorrentManagerFile>);
				ITorrentManagerFile current4 = default(ITorrentManagerFile);
				bool flag6 = default(bool);
				ITorrentManagerFile current2 = default(ITorrentManagerFile);
				bool flag4 = default(bool);
				bool flag3 = default(bool);
				int num7 = default(int);
				ITorrentManagerFile current = default(ITorrentManagerFile);
				IEnumerator<Mapping> enumerator2 = default(IEnumerator<Mapping>);
				Mapping current8 = default(Mapping);
				Mapping current7 = default(Mapping);
				Mapping current6 = default(Mapping);
				TaskAwaiter<int> awaiter3 = default(TaskAwaiter<int>);
				TorrentState state = default(TorrentState);
				bool flag = default(bool);
				bool flag2 = default(bool);
				while (true)
				{
					switch (num4)
					{
					case 37:
						switch (0)
						{
						default:
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						switch (num3)
						{
						case 0:
							goto IL_029a;
						case 1:
						case 2:
						case 3:
						case 4:
						case 5:
							goto IL_0668;
						case 6:
							goto IL_3022;
						case 7:
							goto IL_47f6;
						}
						num = 20;
						num4 = num;
						continue;
					case 20:
						num = 23;
						num4 = num;
						continue;
					case 23:
						eval_n = Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
						{
							short num9 = 31684;
							short num10 = num9;
							num9 = 31684;
							switch (num10 == num9)
							{
							default:
								num9 = 0;
								_ = num9;
								num9 = 1;
								if (num9 != 0)
								{
								}
								num9 = 0;
								if (num9 != 0)
								{
								}
								return A_0 is MainWindow;
							}
						}) as MainWindow;
						eval_o = 0L;
						num = 35;
						num4 = num;
						continue;
					case 35:
						goto IL_029a;
					case 19:
						try
						{
							num = 5;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 5:
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
										num = 8;
										num4 = num;
										continue;
									}
									awaiter = eval_q;
									eval_q = default(TaskAwaiter<TorrentManager>);
									num3 = (eval_a = -1);
									num = 6;
									num4 = num;
									continue;
								case 6:
									result = awaiter.GetResult();
									num = 3;
									num4 = num;
									continue;
								case 3:
								{
									StatusMessageEventHandler statusMessageEventHandler2 = StandardDownloader.m_eval_a;
									if (statusMessageEventHandler2 == null)
									{
										num = 7;
										num4 = num;
									}
									else
									{
										statusMessageEventHandler2(CS_0024_003C_003E8__locals0, "DownloadAsync," + result.InfoHashes.V1OrV2.ToHex());
										num = 0;
										num4 = num;
									}
									continue;
								}
								case 8:
								{
									TorrentSettingsBuilder torrentSettingsBuilder = new TorrentSettingsBuilder
									{
										MaximumConnections = 500
									};
									awaiter = CS_0024_003C_003E8__locals0.Engine.AddAsync(eval_d, eval_e, torrentSettingsBuilder.ToSettings()).GetAwaiter();
									num = 2;
									num4 = num;
									continue;
								}
								case 2:
									if (!awaiter.IsCompleted)
									{
										num = 4;
										num4 = num;
										continue;
									}
									goto case 6;
								case 4:
									num3 = (eval_a = 0);
									eval_q = awaiter;
									eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
									num = 9;
									num4 = num;
									continue;
								case 9:
									return;
								case 0:
								case 7:
									num = 1;
									num4 = num;
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						catch (Exception ex)
						{
							StandardDownloader.m_eval_a?.Invoke(CS_0024_003C_003E8__locals0, "DownloadAsync,Couldn't decode : " + eval_d);
							StandardDownloader.m_eval_a?.Invoke(CS_0024_003C_003E8__locals0, "DownloadAsync," + ex.Message);
						}
						num = 44;
						num4 = num;
						continue;
					case 44:
						if (CS_0024_003C_003E8__locals0.Engine.Torrents.Count == 0)
						{
							num = 7;
							num4 = num;
						}
						else
						{
							eval_r = CS_0024_003C_003E8__locals0.Engine.Torrents.GetEnumerator();
							num = 10;
							num4 = num;
						}
						continue;
					case 7:
						num = 46;
						num4 = num;
						continue;
					case 46:
					{
						StatusMessageEventHandler statusMessageEventHandler13 = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler13 == null)
						{
							num = 1;
							num4 = num;
						}
						else
						{
							statusMessageEventHandler13(CS_0024_003C_003E8__locals0, "DownloadAsync,No torrents found in '" + eval_d + "'");
							num = 25;
							num4 = num;
						}
						continue;
					}
					case 1:
					case 25:
						num = 4;
						num4 = num;
						continue;
					case 4:
					{
						StatusMessageEventHandler statusMessageEventHandler10 = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler10 == null)
						{
							num = 6;
							num4 = num;
						}
						else
						{
							statusMessageEventHandler10(CS_0024_003C_003E8__locals0, "DownloadAsync,Exiting...");
							num = 12;
							num4 = num;
						}
						continue;
					}
					case 6:
					case 12:
						num = 11;
						num4 = num;
						continue;
					case 11:
						goto end_IL_010b;
					case 10:
						goto IL_0668;
					case 8:
						try
						{
							num = 34;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 34:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								default:
									switch (num3)
									{
									case 2:
									case 3:
										goto IL_14d0;
									case 5:
										goto IL_1525;
									case 4:
										goto IL_1560;
									case 1:
										goto IL_15b6;
									}
									num = 21;
									num4 = num;
									continue;
								case 21:
									num = 12;
									num4 = num;
									continue;
								case 26:
									eval_n.eval_fo.Maximum = eval_o;
									num = 0;
									num4 = num;
									continue;
								case 42:
									if (eval_o != 0L)
									{
										num = 10;
										num4 = num;
									}
									else
									{
										eval_n.eval_fo.Maximum = 100.0;
										num = 43;
										num4 = num;
									}
									continue;
								case 45:
									if (eval_o == 0L)
									{
										eval_n.eval_fo.Maximum = 100.0;
										num = 39;
										num4 = num;
									}
									else
									{
										num = 26;
										num4 = num;
									}
									continue;
								case 22:
									try
									{
										num = 12;
										num4 = num;
										while (true)
										{
											switch (num4)
											{
											case 12:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											default:
												if (num3 != 2)
												{
													num = 8;
													num4 = num;
													continue;
												}
												awaiter2 = eval_u;
												eval_u = default(TaskAwaiter);
												num3 = (eval_a = -1);
												num = 22;
												num4 = num;
												continue;
											case 32:
												eval_o += current3.Length;
												num = 3;
												num4 = num;
												continue;
											case 27:
												num = 20;
												num4 = num;
												continue;
											case 20:
												if (flag5)
												{
													num = 32;
													num4 = num;
													continue;
												}
												goto case 3;
											case 6:
												num = 5;
												num4 = num;
												continue;
											case 18:
												num = 26;
												num4 = num;
												continue;
											case 26:
												if (flag5)
												{
													num = 21;
													num4 = num;
													continue;
												}
												goto case 9;
											case 19:
											case 36:
												num = 29;
												num4 = num;
												continue;
											case 29:
												if (num8 >= eval_i.Count)
												{
													num = 18;
													num4 = num;
												}
												else
												{
													num = 39;
													num4 = num;
												}
												continue;
											case 33:
												awaiter2.GetResult();
												num = 0;
												num4 = num;
												continue;
											case 39:
												if (!File.Exists(current3.FullPath))
												{
													num = 35;
													num4 = num;
													continue;
												}
												goto case 37;
											case 40:
												num3 = (eval_a = 2);
												eval_u = awaiter2;
												eval_b.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												num = 23;
												num4 = num;
												continue;
											case 23:
												return;
											case 22:
												awaiter2.GetResult();
												num = 28;
												num4 = num;
												continue;
											case 8:
												num = 11;
												num4 = num;
												continue;
											case 11:
												if (num3 != 3)
												{
													num = 6;
													num4 = num;
													continue;
												}
												awaiter2 = eval_u;
												eval_u = default(TaskAwaiter);
												num3 = (eval_a = -1);
												num = 33;
												num4 = num;
												continue;
											case 25:
												num3 = (eval_a = 3);
												eval_u = awaiter2;
												eval_b.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												num = 15;
												num4 = num;
												continue;
											case 15:
												return;
											case 3:
												num = 7;
												num4 = num;
												continue;
											case 7:
												if (!flag5)
												{
													num = 30;
													num4 = num;
													continue;
												}
												goto case 0;
											case 24:
												flag5 = true;
												num = 27;
												num4 = num;
												continue;
											case 30:
												awaiter2 = eval_s.SetFilePriorityAsync(current3, Priority.DoNotDownload).GetAwaiter();
												num = 13;
												num4 = num;
												continue;
											case 13:
												if (!awaiter2.IsCompleted)
												{
													num = 40;
													num4 = num;
													continue;
												}
												goto case 22;
											case 31:
												num = 2;
												num4 = num;
												continue;
											case 2:
												if (!File.Exists(current3.FullPath))
												{
													num = 24;
													num4 = num;
													continue;
												}
												goto case 27;
											case 37:
												num8++;
												num = 19;
												num4 = num;
												continue;
											case 0:
											case 5:
											case 28:
												num = 41;
												num4 = num;
												continue;
											case 41:
												if (!eval_t.MoveNext())
												{
													num = 38;
													num4 = num;
													continue;
												}
												current3 = eval_t.Current;
												flag5 = false;
												num = 4;
												num4 = num;
												continue;
											case 21:
												eval_o += current3.Length;
												num = 9;
												num4 = num;
												continue;
											case 1:
												flag5 = true;
												num = 37;
												num4 = num;
												continue;
											case 35:
												num = 17;
												num4 = num;
												continue;
											case 17:
												if (current3.FullPath == eval_i[num8])
												{
													num = 1;
													num4 = num;
													continue;
												}
												goto case 37;
											case 4:
												if (eval_h)
												{
													num8 = 0;
													num = 36;
													num4 = num;
												}
												else
												{
													num = 31;
													num4 = num;
												}
												continue;
											case 34:
												awaiter2 = eval_s.SetFilePriorityAsync(current3, Priority.DoNotDownload).GetAwaiter();
												num = 10;
												num4 = num;
												continue;
											case 10:
												if (!awaiter2.IsCompleted)
												{
													num = 25;
													num4 = num;
													continue;
												}
												goto case 33;
											case 9:
												num = 16;
												num4 = num;
												continue;
											case 16:
												if (!flag5)
												{
													num = 34;
													num4 = num;
													continue;
												}
												goto case 0;
											case 38:
												num = 14;
												num4 = num;
												continue;
											case 14:
												break;
											}
											break;
										}
									}
									finally
									{
										num = 2;
										num4 = num;
										while (true)
										{
											switch (num4)
											{
											case 2:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											default:
												if (num3 < 0)
												{
													num = 1;
													num4 = num;
													continue;
												}
												break;
											case 0:
												eval_t.Dispose();
												num = 3;
												num4 = num;
												continue;
											case 3:
												break;
											case 1:
												num = 4;
												num4 = num;
												continue;
											case 4:
												if (eval_t != null)
												{
													num = 0;
													num4 = num;
													continue;
												}
												break;
											}
											break;
										}
									}
									eval_t = null;
									num = 42;
									num4 = num;
									continue;
								case 0:
								case 29:
								case 36:
								case 39:
									eval_s.PeerConnected += (object A_0, [global::eval_b(1)] PeerConnectedEventArgs A_1) =>
									{
										short num22 = 12431;
										short num23 = num22;
										num22 = 12431;
										switch (num23 == num22)
										{
										default:
											num22 = 0;
											_ = num22;
											break;
										case true:
											break;
										case false:
										case true:
											return;
										}
										num22 = 0;
										if (num22 != 0)
										{
										}
										num22 = 1;
										if (num22 != 0)
										{
										}
										Top10Listener obj7 = CS_0024_003C_003E8__locals0.Listener;
										bool lockTaken4 = false;
										try
										{
											int num24 = default(int);
											switch (0)
											{
											default:
												while (true)
												{
													switch (num24)
													{
													case 1:
													{
														StatusMessageEventHandler statusMessageEventHandler19 = StandardDownloader.m_eval_a;
														if (statusMessageEventHandler19 == null)
														{
															num22 = 0;
															num24 = num22;
														}
														else
														{
															statusMessageEventHandler19(CS_0024_003C_003E8__locals0, "DownloadAsync," + $"Connection succeeded: {A_1.Peer.Uri}");
															num22 = 2;
															num24 = num22;
														}
														continue;
													}
													case 0:
														return;
													case 2:
														return;
													}
													break;
												}
												goto case 0;
											case 0:
												Monitor.Enter(obj7, ref lockTaken4);
												CS_0024_003C_003E8__locals0.Listener.WriteLine($"Connection succeeded: {A_1.Peer.Uri}");
												num22 = 1;
												num24 = num22;
												goto default;
											}
										}
										finally
										{
											num22 = 1;
											int num24 = num22;
											while (true)
											{
												switch (num24)
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
													if (lockTaken4)
													{
														num22 = 0;
														num24 = num22;
														continue;
													}
													break;
												case 0:
													Monitor.Exit(obj7);
													num22 = 2;
													num24 = num22;
													continue;
												case 2:
													break;
												}
												break;
											}
										}
									};
									eval_s.ConnectionAttemptFailed += (object A_0, [global::eval_b(1)] ConnectionAttemptFailedEventArgs A_1) =>
									{
										short num19 = -24156;
										short num20 = num19;
										num19 = -24156;
										switch (num20 == num19)
										{
										default:
											num19 = 0;
											_ = num19;
											break;
										case true:
											break;
										case false:
										case true:
											return;
										}
										num19 = 0;
										if (num19 != 0)
										{
										}
										num19 = 1;
										if (num19 != 0)
										{
										}
										Top10Listener obj6 = CS_0024_003C_003E8__locals0.Listener;
										bool lockTaken3 = false;
										try
										{
											int num21 = default(int);
											switch (0)
											{
											default:
												while (true)
												{
													switch (num21)
													{
													case 1:
													{
														StatusMessageEventHandler statusMessageEventHandler18 = StandardDownloader.m_eval_a;
														if (statusMessageEventHandler18 == null)
														{
															num19 = 0;
															num21 = num19;
														}
														else
														{
															statusMessageEventHandler18(CS_0024_003C_003E8__locals0, "DownloadAsync," + $"Connection failed: {A_1.Peer.ConnectionUri} - {A_1.Reason}");
															num19 = 2;
															num21 = num19;
														}
														continue;
													}
													case 0:
														return;
													case 2:
														return;
													}
													break;
												}
												goto case 0;
											case 0:
												Monitor.Enter(obj6, ref lockTaken3);
												CS_0024_003C_003E8__locals0.Listener.WriteLine($"Connection failed: {A_1.Peer.ConnectionUri} - {A_1.Reason}");
												num19 = 1;
												num21 = num19;
												goto default;
											}
										}
										finally
										{
											num19 = 1;
											int num21 = num19;
											while (true)
											{
												switch (num21)
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
													if (lockTaken3)
													{
														num19 = 0;
														num21 = num19;
														continue;
													}
													break;
												case 0:
													Monitor.Exit(obj6);
													num19 = 2;
													num21 = num19;
													continue;
												case 2:
													break;
												}
												break;
											}
										}
									};
									eval_s.PieceHashed += delegate(object A_0, PieceHashedEventArgs A_1)
									{
										short num16 = 14618;
										short num17 = num16;
										num16 = 14618;
										switch (num17 == num16)
										{
										default:
											num16 = 0;
											_ = num16;
											break;
										case true:
											break;
										case false:
										case true:
											return;
										}
										num16 = 0;
										if (num16 != 0)
										{
										}
										num16 = 1;
										if (num16 != 0)
										{
										}
										Top10Listener obj5 = CS_0024_003C_003E8__locals0.Listener;
										bool lockTaken2 = false;
										try
										{
											Monitor.Enter(obj5, ref lockTaken2);
											CS_0024_003C_003E8__locals0.Listener.WriteLine(string.Format("Piece Hashed: {0} - {1}", A_1.PieceIndex, A_1.HashPassed ? "Pass" : "Fail"));
										}
										finally
										{
											num16 = 1;
											int num18 = num16;
											while (true)
											{
												switch (num18)
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
													if (lockTaken2)
													{
														num16 = 0;
														num18 = num16;
														continue;
													}
													break;
												case 0:
													Monitor.Exit(obj5);
													num16 = 2;
													num18 = num16;
													continue;
												case 2:
													break;
												}
												break;
											}
										}
									};
									eval_s.TorrentStateChanged += delegate(object A_0, TorrentStateChangedEventArgs A_1)
									{
										short num13 = 272;
										short num14 = num13;
										num13 = 272;
										switch (num14 == num13)
										{
										default:
											num13 = 0;
											_ = num13;
											break;
										case true:
											break;
										case false:
										case true:
											return;
										}
										num13 = 1;
										if (num13 != 0)
										{
										}
										num13 = 0;
										if (num13 != 0)
										{
										}
										Top10Listener obj4 = CS_0024_003C_003E8__locals0.Listener;
										bool lockTaken = false;
										try
										{
											int num15 = default(int);
											switch (0)
											{
											default:
												while (true)
												{
													switch (num15)
													{
													case 1:
													{
														StatusMessageEventHandler statusMessageEventHandler17 = StandardDownloader.m_eval_a;
														if (statusMessageEventHandler17 == null)
														{
															num13 = 0;
															num15 = num13;
														}
														else
														{
															statusMessageEventHandler17(CS_0024_003C_003E8__locals0, "DownloadAsync," + $"OldState: {A_1.OldState} NewState: {A_1.NewState}");
															num13 = 2;
															num15 = num13;
														}
														continue;
													}
													case 0:
														return;
													case 2:
														return;
													}
													break;
												}
												goto case 0;
											case 0:
												Monitor.Enter(obj4, ref lockTaken);
												CS_0024_003C_003E8__locals0.Listener.WriteLine($"OldState: {A_1.OldState} NewState: {A_1.NewState}");
												num13 = 1;
												num15 = num13;
												goto default;
											}
										}
										finally
										{
											num13 = 1;
											int num15 = num13;
											while (true)
											{
												switch (num15)
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
														num13 = 0;
														num15 = num13;
														continue;
													}
													break;
												case 0:
													Monitor.Exit(obj4);
													num13 = 2;
													num15 = num13;
													continue;
												case 2:
													break;
												}
												break;
											}
										}
									};
									eval_s.TrackerManager.AnnounceComplete += (object A_0, [global::eval_b(1)] AnnounceResponseEventArgs A_1) =>
									{
										short num11 = -27692;
										short num12 = num11;
										num11 = -27692;
										switch (num12 == num11)
										{
										default:
											num11 = 0;
											_ = num11;
											num11 = 1;
											if (num11 != 0)
											{
											}
											num11 = 0;
											if (num11 != 0)
											{
											}
											CS_0024_003C_003E8__locals0.Listener.WriteLine($"{A_1.Successful}: {A_1.Tracker}");
											StandardDownloader.m_eval_a?.Invoke(CS_0024_003C_003E8__locals0, "DownloadAsync," + $"{A_1.Successful}: {A_1.Tracker}");
											break;
										}
									};
									awaiter2 = eval_s.StartAsync().GetAwaiter();
									num = 13;
									num4 = num;
									continue;
								case 13:
									if (!awaiter2.IsCompleted)
									{
										num = 25;
										num4 = num;
										continue;
									}
									goto case 15;
								case 31:
								case 43:
									num = 8;
									num4 = num;
									continue;
								case 8:
									if (!eval_g)
									{
										num = 18;
										num4 = num;
										continue;
									}
									goto case 0;
								case 30:
									if (eval_g)
									{
										num = 5;
										num4 = num;
										continue;
									}
									goto case 31;
								case 7:
									eval_n.eval_fo.Maximum = eval_o;
									num = 29;
									num4 = num;
									continue;
								case 24:
									eval_t = eval_s.Files.GetEnumerator();
									num = 20;
									num4 = num;
									continue;
								case 9:
									try
									{
										num = 9;
										num4 = num;
										while (true)
										{
											switch (num4)
											{
											case 9:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											case 1:
												num = 6;
												num4 = num;
												continue;
											case 6:
												if (flag7)
												{
													num = 8;
													num4 = num;
													continue;
												}
												goto default;
											case 2:
												if (!File.Exists(current5.FullPath))
												{
													num = 7;
													num4 = num;
													continue;
												}
												goto case 1;
											default:
												num = 0;
												num4 = num;
												continue;
											case 0:
												if (enumerator.MoveNext())
												{
													current5 = enumerator.Current;
													flag7 = false;
													num = 2;
													num4 = num;
												}
												else
												{
													num = 4;
													num4 = num;
												}
												continue;
											case 7:
												flag7 = true;
												num = 1;
												num4 = num;
												continue;
											case 8:
												eval_o += current5.Length;
												num = 3;
												num4 = num;
												continue;
											case 4:
												num = 5;
												num4 = num;
												continue;
											case 5:
												break;
											}
											break;
										}
									}
									finally
									{
										num = 4;
										num4 = num;
										while (true)
										{
											switch (num4)
											{
											case 4:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											default:
												if (num3 < 0)
												{
													num = 3;
													num4 = num;
													continue;
												}
												break;
											case 3:
												num = 0;
												num4 = num;
												continue;
											case 0:
												if (enumerator != null)
												{
													num = 2;
													num4 = num;
													continue;
												}
												break;
											case 2:
												enumerator.Dispose();
												num = 1;
												num4 = num;
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									goto case 0;
								case 6:
									num = 4;
									num4 = num;
									continue;
								case 4:
									if (eval_g)
									{
										num = 2;
										num4 = num;
										continue;
									}
									goto case 11;
								case 44:
									goto IL_14d0;
								case 20:
									goto IL_1560;
								case 28:
									goto IL_15b6;
								case 10:
									eval_n.eval_fo.Maximum = eval_o;
									num = 31;
									num4 = num;
									continue;
								case 35:
									enumerator = eval_s.Files.GetEnumerator();
									num = 19;
									num4 = num;
									continue;
								case 15:
									awaiter2.GetResult();
									eval_s = null;
									num = 17;
									num4 = num;
									continue;
								case 25:
									num3 = (eval_a = 5);
									eval_u = awaiter2;
									eval_b.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
									num = 1;
									num4 = num;
									continue;
								case 1:
									return;
								case 16:
									if (!eval_f)
									{
										num = 30;
										num4 = num;
									}
									else
									{
										num = 6;
										num4 = num;
									}
									continue;
								case 19:
									try
									{
										num = 14;
										num4 = num;
										while (true)
										{
											switch (num4)
											{
											case 14:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											case 1:
												num = 10;
												num4 = num;
												continue;
											case 10:
											{
												StatusMessageEventHandler statusMessageEventHandler6 = StandardDownloader.m_eval_a;
												if (statusMessageEventHandler6 != null)
												{
													statusMessageEventHandler6(CS_0024_003C_003E8__locals0, "Engine,Path : " + Path.GetDirectoryName(current4.Path));
													num = 3;
													num4 = num;
												}
												else
												{
													num = 9;
													num4 = num;
												}
												continue;
											}
											case 8:
												flag6 = true;
												num = 11;
												num4 = num;
												continue;
											case 6:
												eval_o += current4.Length;
												num = 2;
												num4 = num;
												continue;
											default:
												num = 13;
												num4 = num;
												continue;
											case 13:
												if (!enumerator.MoveNext())
												{
													num = 7;
													num4 = num;
												}
												else
												{
													current4 = enumerator.Current;
													num = 0;
													num4 = num;
												}
												continue;
											case 11:
												num = 12;
												num4 = num;
												continue;
											case 12:
												if (flag6)
												{
													num = 6;
													num4 = num;
													continue;
												}
												goto default;
											case 0:
												if (!string.IsNullOrEmpty(Path.GetDirectoryName(current4.Path)))
												{
													num = 1;
													num4 = num;
													continue;
												}
												goto case 3;
											case 3:
											case 9:
												flag6 = false;
												num = 4;
												num4 = num;
												continue;
											case 4:
												if (!File.Exists(current4.FullPath))
												{
													num = 8;
													num4 = num;
													continue;
												}
												goto case 11;
											case 7:
												num = 5;
												num4 = num;
												continue;
											case 5:
												break;
											}
											break;
										}
									}
									finally
									{
										num = 4;
										num4 = num;
										while (true)
										{
											switch (num4)
											{
											case 4:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											default:
												if (num3 < 0)
												{
													num = 3;
													num4 = num;
													continue;
												}
												break;
											case 3:
												num = 0;
												num4 = num;
												continue;
											case 0:
												if (enumerator != null)
												{
													num = 2;
													num4 = num;
													continue;
												}
												break;
											case 2:
												enumerator.Dispose();
												num = 1;
												num4 = num;
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									num = 45;
									num4 = num;
									continue;
								case 11:
								case 37:
									num = 3;
									num4 = num;
									continue;
								case 3:
									if (!eval_g)
									{
										num = 35;
										num4 = num;
										continue;
									}
									goto case 0;
								case 18:
									num = 38;
									num4 = num;
									continue;
								case 38:
									if (!eval_j)
									{
										enumerator = eval_s.Files.GetEnumerator();
										num = 9;
										num4 = num;
									}
									else
									{
										num = 24;
										num4 = num;
									}
									continue;
								case 40:
									try
									{
										num = 9;
										num4 = num;
										while (true)
										{
											switch (num4)
											{
											case 9:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											default:
												if (num3 != 1)
												{
													num = 18;
													num4 = num;
													continue;
												}
												awaiter2 = eval_u;
												eval_u = default(TaskAwaiter);
												num3 = (eval_a = -1);
												num = 8;
												num4 = num;
												continue;
											case 5:
												eval_o += current2.Length;
												num = 15;
												num4 = num;
												continue;
											case 17:
												flag4 = true;
												num = 0;
												num4 = num;
												continue;
											case 4:
												if (!File.Exists(current2.FullPath))
												{
													num = 17;
													num4 = num;
													continue;
												}
												goto case 0;
											case 15:
												num = 12;
												num4 = num;
												continue;
											case 12:
												if (!flag4)
												{
													num = 2;
													num4 = num;
													continue;
												}
												goto case 3;
											case 8:
												awaiter2.GetResult();
												num = 16;
												num4 = num;
												continue;
											case 18:
												num = 3;
												num4 = num;
												continue;
											case 3:
											case 16:
												num = 10;
												num4 = num;
												continue;
											case 10:
												if (eval_t.MoveNext())
												{
													current2 = eval_t.Current;
													flag4 = false;
													num = 4;
													num4 = num;
												}
												else
												{
													num = 1;
													num4 = num;
												}
												continue;
											case 2:
												awaiter2 = eval_s.SetFilePriorityAsync(current2, Priority.DoNotDownload).GetAwaiter();
												num = 6;
												num4 = num;
												continue;
											case 6:
												if (!awaiter2.IsCompleted)
												{
													num = 7;
													num4 = num;
													continue;
												}
												goto case 8;
											case 7:
												num3 = (eval_a = 1);
												eval_u = awaiter2;
												eval_b.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												num = 13;
												num4 = num;
												continue;
											case 13:
												return;
											case 0:
												num = 11;
												num4 = num;
												continue;
											case 11:
												if (flag4)
												{
													num = 5;
													num4 = num;
													continue;
												}
												goto case 15;
											case 1:
												num = 14;
												num4 = num;
												continue;
											case 14:
												break;
											}
											break;
										}
									}
									finally
									{
										num = 0;
										num4 = num;
										while (true)
										{
											switch (num4)
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
												if (num3 < 0)
												{
													num = 1;
													num4 = num;
													continue;
												}
												break;
											case 1:
												num = 4;
												num4 = num;
												continue;
											case 4:
												if (eval_t != null)
												{
													num = 3;
													num4 = num;
													continue;
												}
												break;
											case 3:
												eval_t.Dispose();
												num = 2;
												num4 = num;
												continue;
											case 2:
												break;
											}
											break;
										}
									}
									eval_t = null;
									num = 41;
									num4 = num;
									continue;
								case 5:
									eval_t = eval_s.Files.GetEnumerator();
									num = 44;
									num4 = num;
									continue;
								case 14:
									eval_n.eval_fo.Maximum = eval_o;
									num = 11;
									num4 = num;
									continue;
								case 2:
									eval_t = eval_s.Files.GetEnumerator();
									num = 28;
									num4 = num;
									continue;
								case 46:
									if (eval_o == 0L)
									{
										eval_n.eval_fo.Maximum = 100.0;
										num = 36;
										num4 = num;
									}
									else
									{
										num = 7;
										num4 = num;
									}
									continue;
								case 41:
									if (eval_o == 0L)
									{
										eval_n.eval_fo.Maximum = 100.0;
										num = 37;
										num4 = num;
									}
									else
									{
										num = 14;
										num4 = num;
									}
									continue;
								case 23:
									try
									{
										num = 5;
										num4 = num;
										while (true)
										{
											switch (num4)
											{
											case 5:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											default:
												if (num3 != 4)
												{
													num = 1;
													num4 = num;
													continue;
												}
												awaiter2 = eval_u;
												eval_u = default(TaskAwaiter);
												num3 = (eval_a = -1);
												num = 16;
												num4 = num;
												continue;
											case 1:
												num = 11;
												num4 = num;
												continue;
											case 14:
												num = 12;
												num4 = num;
												continue;
											case 12:
												if (flag3)
												{
													num = 7;
													num4 = num;
													continue;
												}
												goto case 6;
											case 10:
												num7++;
												num = 20;
												num4 = num;
												continue;
											case 15:
												awaiter2 = eval_s.SetFilePriorityAsync(current, Priority.DoNotDownload).GetAwaiter();
												num = 3;
												num4 = num;
												continue;
											case 3:
												if (!awaiter2.IsCompleted)
												{
													num = 0;
													num4 = num;
													continue;
												}
												goto case 16;
											case 11:
											case 17:
												num = 13;
												num4 = num;
												continue;
											case 13:
												if (eval_t.MoveNext())
												{
													current = eval_t.Current;
													flag3 = false;
													num7 = 0;
													num = 19;
													num4 = num;
												}
												else
												{
													num = 24;
													num4 = num;
												}
												continue;
											case 18:
												flag3 = true;
												num = 10;
												num4 = num;
												continue;
											case 6:
												num = 21;
												num4 = num;
												continue;
											case 21:
												if (!flag3)
												{
													num = 15;
													num4 = num;
													continue;
												}
												goto case 11;
											case 19:
											case 20:
												num = 22;
												num4 = num;
												continue;
											case 22:
												if (num7 >= eval_i.Count)
												{
													num = 14;
													num4 = num;
												}
												else
												{
													num = 2;
													num4 = num;
												}
												continue;
											case 0:
												num3 = (eval_a = 4);
												eval_u = awaiter2;
												eval_b.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												num = 8;
												num4 = num;
												continue;
											case 8:
												return;
											case 16:
												awaiter2.GetResult();
												num = 17;
												num4 = num;
												continue;
											case 7:
												eval_o += current.Length;
												num = 6;
												num4 = num;
												continue;
											case 23:
												num = 4;
												num4 = num;
												continue;
											case 4:
												if (current.FullPath == eval_i[num7])
												{
													num = 18;
													num4 = num;
													continue;
												}
												goto case 10;
											case 2:
												if (!File.Exists(current.FullPath))
												{
													num = 23;
													num4 = num;
													continue;
												}
												goto case 10;
											case 24:
												num = 9;
												num4 = num;
												continue;
											case 9:
												break;
											}
											break;
										}
									}
									finally
									{
										num = 0;
										num4 = num;
										while (true)
										{
											switch (num4)
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
												if (num3 < 0)
												{
													num = 1;
													num4 = num;
													continue;
												}
												break;
											case 1:
												num = 4;
												num4 = num;
												continue;
											case 4:
												if (eval_t != null)
												{
													num = 3;
													num4 = num;
													continue;
												}
												break;
											case 3:
												eval_t.Dispose();
												num = 2;
												num4 = num;
												continue;
											case 2:
												break;
											}
											break;
										}
									}
									eval_t = null;
									num = 46;
									num4 = num;
									continue;
								case 12:
								case 17:
									num = 27;
									num4 = num;
									continue;
								case 27:
									if (eval_r.MoveNext())
									{
										eval_s = eval_r.Current;
										num = 16;
										num4 = num;
									}
									else
									{
										num = 32;
										num4 = num;
									}
									continue;
								case 32:
									num = 33;
									num4 = num;
									continue;
								case 33:
									break;
									IL_15b6:
									num = 40;
									num4 = num;
									continue;
									IL_1560:
									num = 23;
									num4 = num;
									continue;
									IL_1525:
									awaiter2 = eval_u;
									eval_u = default(TaskAwaiter);
									num3 = (eval_a = -1);
									num = 15;
									num4 = num;
									continue;
									IL_14d0:
									num = 22;
									num4 = num;
									continue;
								}
								break;
							}
						}
						finally
						{
							num = 0;
							num4 = num;
							while (true)
							{
								switch (num4)
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
									if (num3 < 0)
									{
										num = 1;
										num4 = num;
										continue;
									}
									break;
								case 2:
									eval_r.Dispose();
									num = 4;
									num4 = num;
									continue;
								case 4:
									break;
								case 1:
									num = 3;
									num4 = num;
									continue;
								case 3:
									if (eval_r != null)
									{
										num = 2;
										num4 = num;
										continue;
									}
									break;
								}
								break;
							}
						}
						eval_r = null;
						eval_p = false;
						CS_0024_003C_003E8__locals0.m_eval_d = 0;
						num = 39;
						num4 = num;
						continue;
					case 16:
					{
						StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler == null)
						{
							num = 38;
							num4 = num;
						}
						else
						{
							statusMessageEventHandler(CS_0024_003C_003E8__locals0, "Engine," + $"Transfer Rate:      {(double)CS_0024_003C_003E8__locals0.Engine.TotalDownloadRate / 1024.0:0.00}kB/sec ↓ / {(double)CS_0024_003C_003E8__locals0.Engine.TotalUploadRate / 1024.0:0.00}kB/sec ↑");
							num = 30;
							num4 = num;
						}
						continue;
					}
					case 30:
					case 38:
						num = 43;
						num4 = num;
						continue;
					case 43:
					{
						StatusMessageEventHandler statusMessageEventHandler16 = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler16 == null)
						{
							num = 32;
							num4 = num;
						}
						else
						{
							statusMessageEventHandler16(CS_0024_003C_003E8__locals0, "Engine," + $"Memory Cache:       {(double)CS_0024_003C_003E8__locals0.Engine.DiskManager.CacheBytesUsed / 1024.0:0.00}/{(double)CS_0024_003C_003E8__locals0.Engine.Settings.DiskCacheBytes / 1024.0:0.00} kB");
							num = 15;
							num4 = num;
						}
						continue;
					}
					case 15:
					case 32:
						num = 0;
						num4 = num;
						continue;
					case 0:
					{
						StatusMessageEventHandler statusMessageEventHandler15 = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler15 == null)
						{
							num = 48;
							num4 = num;
						}
						else
						{
							statusMessageEventHandler15(CS_0024_003C_003E8__locals0, "Engine," + $"Disk IO Rate:       {(double)CS_0024_003C_003E8__locals0.Engine.DiskManager.ReadRate / 1024.0:0.00} kB/s read / {(double)CS_0024_003C_003E8__locals0.Engine.DiskManager.WriteRate / 1024.0:0.00} kB/s write");
							num = 49;
							num4 = num;
						}
						continue;
					}
					case 48:
					case 49:
						num = 33;
						num4 = num;
						continue;
					case 33:
					{
						StatusMessageEventHandler statusMessageEventHandler14 = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler14 == null)
						{
							num = 9;
							num4 = num;
						}
						else
						{
							statusMessageEventHandler14(CS_0024_003C_003E8__locals0, "Engine," + $"Disk IO Total:      {(double)CS_0024_003C_003E8__locals0.Engine.DiskManager.TotalBytesRead / 1024.0:0.00} kB read / {(double)CS_0024_003C_003E8__locals0.Engine.DiskManager.TotalBytesWritten / 1024.0:0.00} kB written");
							num = 40;
							num4 = num;
						}
						continue;
					}
					case 9:
					case 40:
						num = 21;
						num4 = num;
						continue;
					case 21:
					{
						StatusMessageEventHandler statusMessageEventHandler12 = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler12 == null)
						{
							num = 34;
							num4 = num;
						}
						else
						{
							statusMessageEventHandler12(CS_0024_003C_003E8__locals0, "Engine," + $"Open Files:         {CS_0024_003C_003E8__locals0.Engine.DiskManager.OpenFiles} / {CS_0024_003C_003E8__locals0.Engine.DiskManager.MaximumOpenFiles}");
							num = 47;
							num4 = num;
						}
						continue;
					}
					case 34:
					case 47:
						num = 17;
						num4 = num;
						continue;
					case 17:
					{
						StatusMessageEventHandler statusMessageEventHandler11 = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler11 == null)
						{
							num = 5;
							num4 = num;
						}
						else
						{
							statusMessageEventHandler11(CS_0024_003C_003E8__locals0, "Engine," + $"Open Connections:   {CS_0024_003C_003E8__locals0.Engine.ConnectionManager.OpenConnections}");
							num = 24;
							num4 = num;
						}
						continue;
					}
					case 5:
					case 24:
						enumerator2 = CS_0024_003C_003E8__locals0.Engine.PortMappings.Created.GetEnumerator();
						num = 13;
						num4 = num;
						continue;
					case 13:
						try
						{
							num = 2;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 2:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								case 0:
								{
									StatusMessageEventHandler statusMessageEventHandler9 = StandardDownloader.m_eval_a;
									if (statusMessageEventHandler9 == null)
									{
										num = 6;
										num4 = num;
									}
									else
									{
										statusMessageEventHandler9(CS_0024_003C_003E8__locals0, "Engine," + $"Successful Mapping    {current8.PublicPort}:{current8.PrivatePort} ({current8.Protocol})");
										num = 5;
										num4 = num;
									}
									continue;
								}
								default:
									num = 4;
									num4 = num;
									continue;
								case 4:
									if (enumerator2.MoveNext())
									{
										current8 = enumerator2.Current;
										num = 0;
										num4 = num;
									}
									else
									{
										num = 1;
										num4 = num;
									}
									continue;
								case 1:
									num = 3;
									num4 = num;
									continue;
								case 3:
									break;
								}
								break;
							}
						}
						finally
						{
							num = 2;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 2:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								default:
									if (num3 < 0)
									{
										num = 4;
										num4 = num;
										continue;
									}
									break;
								case 4:
									num = 0;
									num4 = num;
									continue;
								case 0:
									if (enumerator2 != null)
									{
										num = 1;
										num4 = num;
										continue;
									}
									break;
								case 1:
									enumerator2.Dispose();
									num = 3;
									num4 = num;
									continue;
								case 3:
									break;
								}
								break;
							}
						}
						enumerator2 = CS_0024_003C_003E8__locals0.Engine.PortMappings.Failed.GetEnumerator();
						num = 28;
						num4 = num;
						continue;
					case 28:
						try
						{
							num = 4;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 4:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								case 6:
								{
									StatusMessageEventHandler statusMessageEventHandler8 = StandardDownloader.m_eval_a;
									if (statusMessageEventHandler8 == null)
									{
										num = 5;
										num4 = num;
									}
									else
									{
										statusMessageEventHandler8(CS_0024_003C_003E8__locals0, "Engine," + $"Failed mapping:       {current7.PublicPort}:{current7.PrivatePort} ({current7.Protocol})");
										num = 3;
										num4 = num;
									}
									continue;
								}
								default:
									num = 2;
									num4 = num;
									continue;
								case 2:
									if (enumerator2.MoveNext())
									{
										current7 = enumerator2.Current;
										num = 6;
										num4 = num;
									}
									else
									{
										num = 1;
										num4 = num;
									}
									continue;
								case 1:
									num = 0;
									num4 = num;
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							num = 2;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 2:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								default:
									if (num3 < 0)
									{
										num = 4;
										num4 = num;
										continue;
									}
									break;
								case 3:
									enumerator2.Dispose();
									num = 0;
									num4 = num;
									continue;
								case 0:
									break;
								case 4:
									num = 1;
									num4 = num;
									continue;
								case 1:
									if (enumerator2 != null)
									{
										num = 3;
										num4 = num;
										continue;
									}
									break;
								}
								break;
							}
						}
						enumerator2 = CS_0024_003C_003E8__locals0.Engine.PortMappings.Pending.GetEnumerator();
						num = 3;
						num4 = num;
						continue;
					case 3:
						try
						{
							num = 4;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 4:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								case 6:
								{
									StatusMessageEventHandler statusMessageEventHandler7 = StandardDownloader.m_eval_a;
									if (statusMessageEventHandler7 == null)
									{
										num = 5;
										num4 = num;
									}
									else
									{
										statusMessageEventHandler7(CS_0024_003C_003E8__locals0, "Engine," + $"Pending mapping:      {current6.PublicPort}:{current6.PrivatePort} ({current6.Protocol})");
										num = 3;
										num4 = num;
									}
									continue;
								}
								default:
									num = 2;
									num4 = num;
									continue;
								case 2:
									if (enumerator2.MoveNext())
									{
										current6 = enumerator2.Current;
										num = 6;
										num4 = num;
									}
									else
									{
										num = 1;
										num4 = num;
									}
									continue;
								case 1:
									num = 0;
									num4 = num;
									continue;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							num = 2;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 2:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								default:
									if (num3 < 0)
									{
										num = 4;
										num4 = num;
										continue;
									}
									break;
								case 4:
									num = 0;
									num4 = num;
									continue;
								case 0:
									if (enumerator2 != null)
									{
										num = 1;
										num4 = num;
										continue;
									}
									break;
								case 1:
									enumerator2.Dispose();
									num = 3;
									num4 = num;
									continue;
								case 3:
									break;
								}
								break;
							}
						}
						eval_v = false;
						eval_w = false;
						eval_r = CS_0024_003C_003E8__locals0.Engine.Torrents.GetEnumerator();
						num = 41;
						num4 = num;
						continue;
					case 41:
						goto IL_3022;
					case 36:
						try
						{
							num = 18;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 18:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								default:
									if (num3 != 6)
									{
										num = 80;
										num4 = num;
										continue;
									}
									awaiter3 = eval_z;
									eval_z = default(TaskAwaiter<int>);
									num3 = (eval_a = -1);
									num = 21;
									num4 = num;
									continue;
								case 40:
									switch (state)
									{
									default:
										num = 62;
										num4 = num;
										continue;
									case TorrentState.Hashing:
										eval_x = string.Format(NumberFormatInfo.InvariantInfo, " {0} {1:0.0} %", "Checking game files", eval_s.Progress);
										eval_n.eval_fp.Content = eval_x;
										eval_v = true;
										num = 98;
										num4 = num;
										continue;
									case TorrentState.Downloading:
										num = 0;
										num4 = num;
										continue;
									case TorrentState.Starting:
										eval_x = "Start";
										num = 24;
										num4 = num;
										continue;
									case TorrentState.Paused:
									case TorrentState.Stopping:
									case TorrentState.Metadata:
									case TorrentState.FetchingHashes:
										break;
									case TorrentState.Seeding:
										eval_x = "Distribution";
										flag = true;
										num = 52;
										num4 = num;
										continue;
									case TorrentState.HashingPaused:
										eval_x = "Pause File Checks";
										eval_n.eval_fp.Content = eval_x;
										num = 91;
										num4 = num;
										continue;
									case TorrentState.Stopped:
										eval_x = "Stop";
										num = 53;
										num4 = num;
										continue;
									case TorrentState.Error:
										eval_x = "Error";
										flag2 = true;
										eval_n.eval_fp.Content = eval_x;
										num = 31;
										num4 = num;
										continue;
									}
									goto case 3;
								case 16:
									num = 56;
									num4 = num;
									continue;
								case 56:
									if (eval_s.Torrent != null)
									{
										num = 17;
										num4 = num;
										continue;
									}
									goto case 59;
								case 28:
									if (!eval_g)
									{
										num = 5;
										num4 = num;
										continue;
									}
									goto case 59;
								case 82:
									try
									{
										num = 2;
										num4 = num;
										while (true)
										{
											switch (num4)
											{
											case 2:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											default:
												if (eval_o > eval_s.Monitor.DataBytesReceived)
												{
													num = 0;
													num4 = num;
													continue;
												}
												break;
											case 0:
												eval_n.eval_fo.Value = eval_s.Monitor.DataBytesReceived;
												num = 1;
												num4 = num;
												continue;
											case 1:
												break;
											case 3:
												goto end_IL_339a;
											}
											num = 3;
											num4 = num;
											continue;
											end_IL_339a:
											break;
										}
									}
									catch
									{
									}
									goto IL_32d6;
								case 72:
									num = 63;
									num4 = num;
									continue;
								case 63:
									if (eval_g)
									{
										num = 12;
										num4 = num;
										continue;
									}
									goto case 29;
								case 37:
									eval_p = true;
									eval_l = false;
									eval_v = true;
									eval_g = false;
									num = 20;
									num4 = num;
									continue;
								case 20:
								{
									StatusMessageEventHandler statusMessageEventHandler4 = StandardDownloader.m_eval_a;
									if (statusMessageEventHandler4 == null)
									{
										num = 10;
										num4 = num;
									}
									else
									{
										statusMessageEventHandler4(CS_0024_003C_003E8__locals0, "WRITEVER");
										num = 87;
										num4 = num;
									}
									continue;
								}
								case 0:
									if (!eval_g)
									{
										num = 67;
										num4 = num;
										continue;
									}
									goto case 72;
								case 61:
								case 84:
									num = 39;
									num4 = num;
									continue;
								case 39:
									if (!eval_r.MoveNext())
									{
										num = 45;
										num4 = num;
										continue;
									}
									eval_s = eval_r.Current;
									eval_x = string.Empty;
									flag = false;
									eval_y = string.Empty;
									flag2 = false;
									num = 78;
									num4 = num;
									continue;
								case 4:
									num = 35;
									num4 = num;
									continue;
								case 35:
									if (eval_o != 0L)
									{
										num = 16;
										num4 = num;
									}
									else
									{
										flag = true;
										num = 59;
										num4 = num;
									}
									continue;
								case 64:
									num = 74;
									num4 = num;
									continue;
								case 74:
									if (string.IsNullOrEmpty(eval_x))
									{
										num = 51;
										num4 = num;
										continue;
									}
									goto case 7;
								case 24:
								{
									StatusMessageEventHandler statusMessageEventHandler3 = StandardDownloader.m_eval_a;
									if (statusMessageEventHandler3 == null)
									{
										num = 93;
										num4 = num;
									}
									else
									{
										statusMessageEventHandler3(CS_0024_003C_003E8__locals0, "DownloadAsync,starting...");
										num = 9;
										num4 = num;
									}
									continue;
								}
								case 30:
									try
									{
										eval_n.eval_fo.Value = eval_s.Progress;
									}
									catch
									{
									}
									goto case 59;
								case 5:
									num = 96;
									num4 = num;
									continue;
								case 96:
									if (eval_j)
									{
										num = 71;
										num4 = num;
									}
									else
									{
										num = 30;
										num4 = num;
									}
									continue;
								case 48:
									if (!eval_g)
									{
										num = 83;
										num4 = num;
										continue;
									}
									goto case 43;
								case 54:
								case 73:
								case 81:
									eval_x = null;
									eval_y = null;
									eval_s = null;
									num = 61;
									num4 = num;
									continue;
								case 94:
									if (eval_w)
									{
										num = 92;
										num4 = num;
										continue;
									}
									goto case 54;
								case 58:
									eval_n.eval_fp.Content = "Соединение с сервером";
									num = 81;
									num4 = num;
									continue;
								case 15:
									num = 95;
									num4 = num;
									continue;
								case 27:
								{
									StatusMessageEventHandler statusMessageEventHandler5 = StandardDownloader.m_eval_a;
									if (statusMessageEventHandler5 != null)
									{
										statusMessageEventHandler5(CS_0024_003C_003E8__locals0, "DownloadAsync,запущен...");
										num = 8;
										num4 = num;
									}
									else
									{
										num = 55;
										num4 = num;
									}
									continue;
								}
								case 76:
									num = 86;
									num4 = num;
									continue;
								case 86:
									if (eval_o > eval_s.Monitor.DataBytesReceived)
									{
										num = 90;
										num4 = num;
										continue;
									}
									goto case 64;
								case 7:
									eval_w = true;
									num = 49;
									num4 = num;
									continue;
								case 99:
									eval_n.eval_fq.Content = "Время: " + CS_0024_003C_003E8__locals0.TimeLeft(eval_s.Monitor.DownloadRate, eval_o, eval_s.Monitor.DataBytesReceived, eval_k);
									eval_n.eval_fp.Content = "Скорость: " + CS_0024_003C_003E8__locals0.AllNumberToSpeed(eval_s.Monitor.DownloadRate, eval_k) + "/" + CS_0024_003C_003E8__locals0.AllNumberToSpeed(eval_s.Monitor.UploadRate, eval_k) + "[" + CS_0024_003C_003E8__locals0.TotalFile(eval_s.Monitor.DataBytesReceived, eval_k) + "]";
									num = 33;
									num4 = num;
									continue;
								case 60:
									eval_w = true;
									num = 97;
									num4 = num;
									continue;
								case 59:
									num = 57;
									num4 = num;
									continue;
								case 57:
									if (flag)
									{
										num = 37;
										num4 = num;
										continue;
									}
									goto case 79;
								case 95:
									eval_x = eval_s.State.ToString();
									num = 77;
									num4 = num;
									continue;
								case 3:
								case 8:
								case 9:
								case 13:
								case 25:
								case 31:
								case 32:
								case 49:
								case 52:
								case 53:
								case 55:
								case 69:
								case 70:
								case 77:
								case 91:
								case 93:
								case 97:
								case 98:
									num = 6;
									num4 = num;
									continue;
								case 6:
									if (!flag2)
									{
										num = 4;
										num4 = num;
										continue;
									}
									goto case 54;
								case 51:
									eval_x = "100.0 %";
									num = 7;
									num4 = num;
									continue;
								case 43:
									num = 41;
									num4 = num;
									continue;
								case 41:
									if (eval_g)
									{
										num = 76;
										num4 = num;
										continue;
									}
									goto case 64;
								case 75:
									state = eval_s.State;
									num = 1;
									num4 = num;
									continue;
								case 1:
									switch (state)
									{
									case TorrentState.Downloading:
										num = 48;
										num4 = num;
										continue;
									case TorrentState.Starting:
										eval_x = "Старт";
										num = 27;
										num4 = num;
										continue;
									case TorrentState.Paused:
									case TorrentState.Stopping:
									case TorrentState.Metadata:
									case TorrentState.FetchingHashes:
										break;
									default:
										num = 15;
										num4 = num;
										continue;
									case TorrentState.HashingPaused:
										eval_x = "Пауза проверки файлов";
										eval_n.eval_fp.Content = eval_x;
										num = 25;
										num4 = num;
										continue;
									case TorrentState.Stopped:
										eval_x = "Стоп";
										num = 70;
										num4 = num;
										continue;
									case TorrentState.Hashing:
										eval_x = string.Format(NumberFormatInfo.InvariantInfo, " {0} {1:0.0} %", "Проверка файлов игры", eval_s.Progress);
										eval_n.eval_fp.Content = eval_x;
										eval_v = true;
										num = 69;
										num4 = num;
										continue;
									case TorrentState.Seeding:
										flag = true;
										num = 32;
										num4 = num;
										continue;
									case TorrentState.Error:
										eval_x = "Ошибка";
										flag2 = true;
										eval_n.eval_fp.Content = eval_x;
										num = 13;
										num4 = num;
										continue;
									}
									goto case 3;
								case 67:
									eval_x = string.Format(NumberFormatInfo.InvariantInfo, " {0} {1:0.0} %", "Downloading", eval_s.Progress);
									eval_y = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.0}", eval_s.Progress);
									num = 72;
									num4 = num;
									continue;
								case 80:
									num = 84;
									num4 = num;
									continue;
								case 42:
									num = 66;
									num4 = num;
									continue;
								case 66:
									if (eval_k == "RU")
									{
										num = 58;
										num4 = num;
									}
									else
									{
										eval_n.eval_fp.Content = "Connection to server";
										num = 54;
										num4 = num;
									}
									continue;
								case 10:
								case 87:
									CS_0024_003C_003E8__locals0.eval_b();
									num = 79;
									num4 = num;
									continue;
								case 62:
									num = 38;
									num4 = num;
									continue;
								case 2:
									num = 89;
									num4 = num;
									continue;
								case 89:
									if (eval_k == "RU")
									{
										num = 99;
										num4 = num;
										continue;
									}
									eval_n.eval_fq.Content = "Time: " + CS_0024_003C_003E8__locals0.TimeLeft(eval_s.Monitor.DownloadRate, eval_o, eval_s.Monitor.DataBytesReceived, eval_k);
									eval_n.eval_fp.Content = "Speed: " + CS_0024_003C_003E8__locals0.AllNumberToSpeed(eval_s.Monitor.DownloadRate, eval_k) + "/" + CS_0024_003C_003E8__locals0.AllNumberToSpeed(eval_s.Monitor.UploadRate, eval_k) + "[" + CS_0024_003C_003E8__locals0.TotalFile(eval_s.Monitor.DataBytesReceived, eval_k) + "]";
									num = 22;
									num4 = num;
									continue;
								case 83:
									eval_x = string.Format(NumberFormatInfo.InvariantInfo, " {0} {1:0.0} %", "Скачивание", eval_s.Progress);
									eval_y = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.0}", eval_s.Progress);
									num = 43;
									num4 = num;
									continue;
								case 47:
									eval_x = "100.0 %";
									num = 60;
									num4 = num;
									continue;
								case 34:
								{
									double num6 = (double)eval_s.Monitor.DataBytesReceived / (double)eval_o * 100.0;
									eval_x = string.Format(NumberFormatInfo.InvariantInfo, " {0} {1:0.0} %", "Downloading", num6);
									eval_y = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.0}", num6);
									num = 29;
									num4 = num;
									continue;
								}
								case 22:
								case 33:
									eval_n.eval_fr.Content = eval_x;
									num = 73;
									num4 = num;
									continue;
								case 12:
									num = 50;
									num4 = num;
									continue;
								case 50:
									if (eval_o > eval_s.Monitor.DataBytesReceived)
									{
										num = 34;
										num4 = num;
										continue;
									}
									goto case 29;
								case 71:
									try
									{
										num = 3;
										num4 = num;
										while (true)
										{
											switch (num4)
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
												if (eval_o > eval_s.Monitor.DataBytesReceived)
												{
													num = 0;
													num4 = num;
													continue;
												}
												break;
											case 0:
												eval_n.eval_fo.Value = eval_s.Monitor.DataBytesReceived;
												num = 2;
												num4 = num;
												continue;
											case 2:
												break;
											case 1:
												goto end_IL_4063;
											}
											num = 1;
											num4 = num;
											continue;
											end_IL_4063:
											break;
										}
									}
									catch
									{
									}
									goto case 59;
								case 14:
									awaiter3 = eval_s.PieceManager.CurrentRequestCountAsync().GetAwaiter();
									num = 44;
									num4 = num;
									continue;
								case 44:
									if (!awaiter3.IsCompleted)
									{
										num = 85;
										num4 = num;
										continue;
									}
									goto case 21;
								case 17:
									num = 88;
									num4 = num;
									continue;
								case 88:
									if (eval_g)
									{
										num = 82;
										num4 = num;
										continue;
									}
									goto IL_32d6;
								case 85:
									num3 = (eval_a = 6);
									eval_z = awaiter3;
									eval_b.AwaitUnsafeOnCompleted(ref awaiter3, ref this);
									num = 68;
									num4 = num;
									continue;
								case 68:
									return;
								case 21:
									num = 65;
									num4 = num;
									continue;
								case 65:
									if (awaiter3.GetResult() != 0)
									{
										num = 94;
										num4 = num;
									}
									else
									{
										num = 42;
										num4 = num;
									}
									continue;
								case 38:
									eval_x = eval_s.State.ToString();
									num = 3;
									num4 = num;
									continue;
								case 78:
									if (!(eval_k == "RU"))
									{
										state = eval_s.State;
										num = 40;
										num4 = num;
									}
									else
									{
										num = 75;
										num4 = num;
									}
									continue;
								case 29:
									num = 26;
									num4 = num;
									continue;
								case 26:
									if (string.IsNullOrEmpty(eval_x))
									{
										num = 47;
										num4 = num;
										continue;
									}
									goto case 60;
								case 11:
									num = 23;
									num4 = num;
									continue;
								case 23:
									if (!eval_v)
									{
										num = 14;
										num4 = num;
										continue;
									}
									goto case 54;
								case 92:
									num = 46;
									num4 = num;
									continue;
								case 46:
									if (eval_y != "100.0")
									{
										num = 2;
										num4 = num;
										continue;
									}
									goto case 54;
								case 90:
								{
									double num5 = (double)eval_s.Monitor.DataBytesReceived / (double)eval_o * 100.0;
									eval_x = string.Format(NumberFormatInfo.InvariantInfo, " {0} {1:0.0} %", "Скачивание", num5);
									eval_y = string.Format(NumberFormatInfo.InvariantInfo, "{0:0.0}", num5);
									num = 64;
									num4 = num;
									continue;
								}
								case 79:
									num = 36;
									num4 = num;
									continue;
								case 36:
									if (eval_s.PieceManager != null)
									{
										num = 11;
										num4 = num;
										continue;
									}
									goto case 54;
								case 45:
									num = 19;
									num4 = num;
									continue;
								case 19:
									break;
									IL_32d6:
									num = 28;
									num4 = num;
									continue;
								}
								break;
							}
						}
						finally
						{
							num = 4;
							num4 = num;
							while (true)
							{
								switch (num4)
								{
								case 4:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								default:
									if (num3 < 0)
									{
										num = 0;
										num4 = num;
										continue;
									}
									break;
								case 0:
									num = 1;
									num4 = num;
									continue;
								case 1:
									if (eval_r != null)
									{
										num = 3;
										num4 = num;
										continue;
									}
									break;
								case 3:
									eval_r.Dispose();
									num = 2;
									num4 = num;
									continue;
								case 2:
									break;
								}
								break;
							}
						}
						eval_r = null;
						CS_0024_003C_003E8__locals0.Listener.ExportTo(Console.Out);
						awaiter2 = Task.Delay(3000, m).GetAwaiter();
						num = 45;
						num4 = num;
						continue;
					case 45:
						if (!awaiter2.IsCompleted)
						{
							num = 2;
							num4 = num;
							continue;
						}
						goto case 26;
					case 2:
						num3 = (eval_a = 7);
						eval_u = awaiter2;
						eval_b.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
						num = 14;
						num4 = num;
						continue;
					case 14:
						return;
					case 26:
						awaiter2.GetResult();
						num = 42;
						num4 = num;
						continue;
					case 39:
					case 42:
						num = 27;
						num4 = num;
						continue;
					case 27:
						if (CS_0024_003C_003E8__locals0.Engine.IsRunning)
						{
							num = 29;
							num4 = num;
							continue;
						}
						break;
					case 29:
						num = 22;
						num4 = num;
						continue;
					case 22:
						if (!eval_p)
						{
							eval_n.eval_fz.Document.Blocks.Clear();
							num = 16;
							num4 = num;
						}
						else
						{
							num = 18;
							num4 = num;
						}
						continue;
					case 18:
						break;
					case 31:
						goto end_IL_010b;
						IL_3022:
						num = 36;
						num4 = num;
						continue;
						IL_029a:
						num = 19;
						num4 = num;
						continue;
						IL_0668:
						num = 8;
						num4 = num;
						continue;
						IL_47f6:
						awaiter2 = eval_u;
						eval_u = default(TaskAwaiter);
						num3 = (eval_a = -1);
						num = 26;
						num4 = num;
						continue;
					}
					num = 31;
					num4 = num;
					continue;
					end_IL_010b:
					break;
				}
			}
			catch (Exception exception)
			{
				eval_a = -2;
				eval_n = null;
				eval_b.SetException(exception);
				return;
			}
			eval_a = -2;
			eval_n = null;
			eval_b.SetResult();
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in eval_m
			this.eval_m();
		}

		[DebuggerHidden]
		private void eval_m(IAsyncStateMachine A_0)
		{
			short num = 0;
			_ = num;
			num = -16481;
			short num2 = num;
			num = -16481;
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
			eval_b.SetStateMachine(A_0);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine A_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in eval_m
			this.eval_m(A_0);
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct eval_b : IAsyncStateMachine
	{
		public int eval_a;

		public AsyncVoidMethodBuilder eval_b;

		public StandardDownloader eval_c;

		[global::eval_b(new byte[] { 0, 1 })]
		private IEnumerator<TorrentManager> m_eval_d;

		private TaskAwaiter eval_e;

		private void eval_d()
		{
			short num = -29804;
			short num2 = num;
			num = -29804;
			switch (num2 == num)
			{
			default:
			{
				num = 0;
				if (num != 0)
				{
				}
				num = 0;
				switch (num)
				{
				}
				int num3 = eval_a;
				StandardDownloader standardDownloader = eval_c;
				try
				{
					num = 1;
					if (num != 0)
					{
					}
					_ = 1;
					try
					{
						num = 2;
						int num4 = num;
						TaskAwaiter awaiter = default(TaskAwaiter);
						while (true)
						{
							switch (num4)
							{
							case 1:
								goto end_IL_00db;
							case 2:
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
									num = 3;
									num4 = num;
									continue;
								}
								goto case 4;
							case 5:
								if (!awaiter.IsCompleted)
								{
									num = 6;
									num4 = num;
									continue;
								}
								break;
							case 9:
								try
								{
									num = 2;
									num4 = num;
									while (true)
									{
										switch (num4)
										{
										case 1:
											break;
										case 2:
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
												num = 3;
												num4 = num;
												continue;
											}
											awaiter = eval_e;
											eval_e = default(TaskAwaiter);
											num3 = (eval_a = -1);
											num = 9;
											num4 = num;
											continue;
										case 5:
											if (!awaiter.IsCompleted)
											{
												num = 6;
												num4 = num;
												continue;
											}
											goto case 9;
										case 3:
											num = 10;
											num4 = num;
											continue;
										case 6:
											num3 = (eval_a = 0);
											eval_e = awaiter;
											eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num = 4;
											num4 = num;
											continue;
										case 4:
											goto end_IL_01c5;
										case 0:
										case 10:
											num = 7;
											num4 = num;
											continue;
										case 7:
											if (this.m_eval_d.MoveNext())
											{
												awaiter = this.m_eval_d.Current.StopAsync().GetAwaiter();
												num = 5;
												num4 = num;
											}
											else
											{
												num = 8;
												num4 = num;
											}
											continue;
										case 9:
											awaiter.GetResult();
											num = 0;
											num4 = num;
											continue;
										case 8:
											num = 1;
											num4 = num;
											continue;
										}
										break;
									}
									goto IL_012f;
									end_IL_01c5:;
								}
								finally
								{
									num = 0;
									num4 = num;
									while (true)
									{
										switch (num4)
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
											if (num3 < 0)
											{
												num = 4;
												num4 = num;
												continue;
											}
											break;
										case 4:
											num = 2;
											num4 = num;
											continue;
										case 2:
											if (this.m_eval_d != null)
											{
												num = 3;
												num4 = num;
												continue;
											}
											break;
										case 3:
											this.m_eval_d.Dispose();
											num = 1;
											num4 = num;
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								goto end_IL_00bc;
							case 0:
								this.m_eval_d = standardDownloader.Engine.Torrents.GetEnumerator();
								num = 4;
								num4 = num;
								continue;
							case 6:
								num3 = (eval_a = 1);
								eval_e = awaiter;
								eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num = 7;
								num4 = num;
								continue;
							case 7:
								goto end_IL_00bc;
							case 3:
								num = 8;
								num4 = num;
								continue;
							case 8:
								if (num3 == 1)
								{
									awaiter = eval_e;
									eval_e = default(TaskAwaiter);
									num3 = (eval_a = -1);
									num = 10;
									num4 = num;
								}
								else
								{
									num = 0;
									num4 = num;
								}
								continue;
							case 4:
								num = 9;
								num4 = num;
								continue;
							case 10:
								break;
								IL_012f:
								this.m_eval_d = null;
								awaiter = standardDownloader.Engine.StopAllAsync().GetAwaiter();
								num = 5;
								num4 = num;
								continue;
							}
							awaiter.GetResult();
							num = 1;
							num4 = num;
							continue;
							end_IL_00db:
							break;
						}
						goto IL_0077;
						end_IL_00bc:;
					}
					catch
					{
						goto IL_0077;
					}
				}
				catch (Exception exception)
				{
					eval_a = -2;
					eval_b.SetException(exception);
				}
				break;
			}
			case false:
			case true:
				break;
				IL_0077:
				eval_a = -2;
				eval_b.SetResult();
				break;
			}
			num = 0;
			_ = num;
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
			num = -3757;
			short num2 = num;
			num = -3757;
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
	private struct eval_c : IAsyncStateMachine
	{
		public int eval_a;

		public AsyncVoidMethodBuilder eval_b;

		public StandardDownloader eval_c;

		[global::eval_b(new byte[] { 0, 1 })]
		private IEnumerator<TorrentManager> m_eval_d;

		private TaskAwaiter eval_e;

		private void eval_d()
		{
			short num = 10437;
			short num2 = num;
			num = 10437;
			switch (num2 == num)
			{
			default:
			{
				num = 0;
				if (num != 0)
				{
				}
				num = 0;
				switch (num)
				{
				}
				int num3 = eval_a;
				StandardDownloader standardDownloader = eval_c;
				try
				{
					num = 1;
					if (num != 0)
					{
					}
					_ = 1;
					try
					{
						num = 4;
						int num4 = num;
						TaskAwaiter awaiter = default(TaskAwaiter);
						while (true)
						{
							switch (num4)
							{
							case 9:
								break;
							case 4:
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
									num = 5;
									num4 = num;
									continue;
								}
								goto case 6;
							case 13:
								this.m_eval_d = standardDownloader.Engine.Torrents.GetEnumerator();
								num = 6;
								num4 = num;
								continue;
							case 2:
								awaiter.GetResult();
								num = 8;
								num4 = num;
								continue;
							case 8:
							{
								StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
								if (statusMessageEventHandler != null)
								{
									statusMessageEventHandler(standardDownloader, "DownloadAsync,CointOpenConnections : Started / Restart Engine Torrent...");
									num = 3;
									num4 = num;
								}
								else
								{
									num = 10;
									num4 = num;
								}
								continue;
							}
							case 5:
								num = 7;
								num4 = num;
								continue;
							case 7:
								if (num3 != 1)
								{
									num = 13;
									num4 = num;
									continue;
								}
								awaiter = eval_e;
								eval_e = default(TaskAwaiter);
								num3 = (eval_a = -1);
								num = 2;
								num4 = num;
								continue;
							case 12:
								try
								{
									num = 2;
									num4 = num;
									while (true)
									{
										switch (num4)
										{
										case 2:
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
												num = 3;
												num4 = num;
												continue;
											}
											awaiter = eval_e;
											eval_e = default(TaskAwaiter);
											num3 = (eval_a = -1);
											num = 5;
											num4 = num;
											continue;
										case 6:
											if (!awaiter.IsCompleted)
											{
												num = 10;
												num4 = num;
												continue;
											}
											goto case 5;
										case 5:
											awaiter.GetResult();
											num = 4;
											num4 = num;
											continue;
										case 3:
											num = 7;
											num4 = num;
											continue;
										case 4:
										case 7:
											num = 8;
											num4 = num;
											continue;
										case 8:
											if (this.m_eval_d.MoveNext())
											{
												awaiter = this.m_eval_d.Current.StartAsync().GetAwaiter();
												num = 6;
												num4 = num;
											}
											else
											{
												num = 0;
												num4 = num;
											}
											continue;
										case 10:
											num3 = (eval_a = 0);
											eval_e = awaiter;
											eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num = 9;
											num4 = num;
											continue;
										case 9:
											break;
										case 0:
											num = 1;
											num4 = num;
											continue;
										case 1:
											goto IL_0511;
										}
										break;
									}
								}
								finally
								{
									num = 0;
									num4 = num;
									while (true)
									{
										switch (num4)
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
											if (num3 < 0)
											{
												num = 4;
												num4 = num;
												continue;
											}
											break;
										case 4:
											num = 2;
											num4 = num;
											continue;
										case 2:
											if (this.m_eval_d != null)
											{
												num = 3;
												num4 = num;
												continue;
											}
											break;
										case 3:
											this.m_eval_d.Dispose();
											num = 1;
											num4 = num;
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								goto end_IL_00bd;
							case 0:
								num3 = (eval_a = 1);
								eval_e = awaiter;
								eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num = 1;
								num4 = num;
								continue;
							case 1:
								goto end_IL_00bd;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num = 0;
									num4 = num;
									continue;
								}
								goto case 2;
							case 6:
								num = 12;
								num4 = num;
								continue;
							case 3:
							case 10:
								{
									standardDownloader.m_eval_d = 0;
									num = 9;
									num4 = num;
									continue;
								}
								IL_0511:
								this.m_eval_d = null;
								awaiter = standardDownloader.Engine.StartAllAsync().GetAwaiter();
								num = 11;
								num4 = num;
								continue;
							}
							break;
						}
						goto IL_0078;
						end_IL_00bd:;
					}
					catch
					{
						goto IL_0078;
					}
				}
				catch (Exception exception)
				{
					eval_a = -2;
					eval_b.SetException(exception);
				}
				break;
			}
			case false:
			case true:
				break;
				IL_0078:
				eval_a = -2;
				eval_b.SetResult();
				break;
			}
			num = 0;
			_ = num;
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
			num = -18362;
			short num2 = num;
			num = -18362;
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
	private struct eval_d : IAsyncStateMachine
	{
		public int eval_a;

		public AsyncVoidMethodBuilder eval_b;

		public StandardDownloader eval_c;

		[global::eval_b(new byte[] { 0, 1 })]
		private IEnumerator<TorrentManager> m_eval_d;

		private TaskAwaiter eval_e;

		private void eval_d()
		{
			short num = 0;
			switch (num)
			{
			}
			num = 0;
			_ = num;
			num = 1;
			if (num != 0)
			{
			}
			int num2 = eval_a;
			StandardDownloader standardDownloader = eval_c;
			try
			{
				num = 24181;
				short num3 = num;
				num = 24181;
				switch (num3 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					_ = 1;
					try
					{
						num = 4;
						int num4 = num;
						TaskAwaiter awaiter = default(TaskAwaiter);
						while (true)
						{
							switch (num4)
							{
							case 4:
								switch (0)
								{
								default:
									continue;
								case 0:
									break;
								}
								goto default;
							default:
								if (num2 != 0)
								{
									num = 5;
									num4 = num;
									continue;
								}
								goto case 6;
							case 13:
								this.m_eval_d = standardDownloader.Engine.Torrents.GetEnumerator();
								num = 6;
								num4 = num;
								continue;
							case 2:
								awaiter.GetResult();
								num = 8;
								num4 = num;
								continue;
							case 8:
							{
								StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
								if (statusMessageEventHandler != null)
								{
									statusMessageEventHandler(standardDownloader, "DownloadAsync,CointOpenConnections : Stoped / Restart Engine Torrent...");
									num = 3;
									num4 = num;
								}
								else
								{
									num = 10;
									num4 = num;
								}
								continue;
							}
							case 5:
								num = 7;
								num4 = num;
								continue;
							case 7:
								if (num2 != 1)
								{
									num = 13;
									num4 = num;
									continue;
								}
								awaiter = eval_e;
								eval_e = default(TaskAwaiter);
								num2 = (eval_a = -1);
								num = 2;
								num4 = num;
								continue;
							case 12:
								try
								{
									num = 2;
									num4 = num;
									while (true)
									{
										switch (num4)
										{
										case 2:
											switch (0)
											{
											default:
												continue;
											case 0:
												break;
											}
											goto default;
										default:
											if (num2 != 0)
											{
												num = 3;
												num4 = num;
												continue;
											}
											awaiter = eval_e;
											eval_e = default(TaskAwaiter);
											num2 = (eval_a = -1);
											num = 5;
											num4 = num;
											continue;
										case 6:
											if (!awaiter.IsCompleted)
											{
												num = 10;
												num4 = num;
												continue;
											}
											goto case 5;
										case 5:
											awaiter.GetResult();
											num = 4;
											num4 = num;
											continue;
										case 3:
											num = 7;
											num4 = num;
											continue;
										case 4:
										case 7:
											num = 8;
											num4 = num;
											continue;
										case 8:
											if (this.m_eval_d.MoveNext())
											{
												awaiter = this.m_eval_d.Current.StopAsync().GetAwaiter();
												num = 6;
												num4 = num;
											}
											else
											{
												num = 0;
												num4 = num;
											}
											continue;
										case 10:
											num2 = (eval_a = 0);
											eval_e = awaiter;
											eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
											num = 9;
											num4 = num;
											continue;
										case 9:
											return;
										case 0:
											num = 1;
											num4 = num;
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								finally
								{
									num = 0;
									num4 = num;
									while (true)
									{
										switch (num4)
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
											if (num2 < 0)
											{
												num = 4;
												num4 = num;
												continue;
											}
											break;
										case 4:
											num = 2;
											num4 = num;
											continue;
										case 2:
											if (this.m_eval_d != null)
											{
												num = 3;
												num4 = num;
												continue;
											}
											break;
										case 3:
											this.m_eval_d.Dispose();
											num = 1;
											num4 = num;
											continue;
										case 1:
											break;
										}
										break;
									}
								}
								this.m_eval_d = null;
								awaiter = standardDownloader.Engine.StopAllAsync().GetAwaiter();
								num = 11;
								num4 = num;
								continue;
							case 0:
								num2 = (eval_a = 1);
								eval_e = awaiter;
								eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
								num = 1;
								num4 = num;
								continue;
							case 1:
								return;
							case 11:
								if (!awaiter.IsCompleted)
								{
									num = 0;
									num4 = num;
									continue;
								}
								goto case 2;
							case 6:
								num = 12;
								num4 = num;
								continue;
							case 3:
							case 10:
								num = 9;
								num4 = num;
								continue;
							case 9:
								break;
							}
							break;
						}
					}
					catch
					{
					}
					break;
				case false:
				case true:
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
			short num = 1;
			if (num != 0)
			{
			}
			num = 0;
			_ = num;
			num = -26636;
			short num2 = num;
			num = -26636;
			switch (num2 == num)
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
	private struct eval_e : IAsyncStateMachine
	{
		public int eval_a;

		public AsyncTaskMethodBuilder eval_b;

		public string eval_c;

		public string d;

		public StandardDownloader eval_e;

		public string eval_f;

		public string eval_g;

		public bool eval_h;

		public string eval_i;

		public CancellationToken j;

		private bool eval_k;

		private MainWindow eval_l;

		private FileStream eval_m;

		[global::eval_b(new byte[] { 0, 1 })]
		private TaskAwaiter<TorrentManager> eval_n;

		[global::eval_b(new byte[] { 0, 1 })]
		private IEnumerator<TorrentManager> eval_o;

		private TaskAwaiter eval_p;

		private void eval_d()
		{
			short num = 0;
			switch (num)
			{
			}
			num = 0;
			_ = num;
			int num2 = eval_a;
			StandardDownloader CS_0024_003C_003E8__locals0 = eval_e;
			try
			{
				num = 14;
				int num3 = num;
				TaskAwaiter awaiter = default(TaskAwaiter);
				TaskAwaiter<TorrentManager> awaiter2 = default(TaskAwaiter<TorrentManager>);
				TorrentManager result = default(TorrentManager);
				IEnumerator<TorrentManager> enumerator = default(IEnumerator<TorrentManager>);
				TorrentState state = default(TorrentState);
				TorrentManager current = default(TorrentManager);
				while (true)
				{
					switch (num3)
					{
					case 9:
					case 13:
						goto end_IL_0095;
					case 14:
						switch (0)
						{
						default:
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						switch (num2)
						{
						case 0:
							goto IL_056e;
						case 1:
							goto IL_0ce6;
						case 2:
							goto IL_112e;
						}
						num = 21;
						num3 = num;
						continue;
					case 21:
						eval_k = false;
						num = 15;
						num3 = num;
						continue;
					case 15:
						eval_l = Application.Current.Windows.Cast<Window>().FirstOrDefault(delegate(Window A_0)
						{
							short num5 = -4652;
							short num6 = num5;
							num5 = -4652;
							switch (num6 == num5)
							{
							default:
								num5 = 0;
								_ = num5;
								num5 = 1;
								if (num5 != 0)
								{
								}
								num5 = 0;
								if (num5 != 0)
								{
								}
								return A_0 is MainWindow;
							}
						}) as MainWindow;
						num = 22;
						num3 = num;
						continue;
					case 0:
						try
						{
							num = 8;
							num3 = num;
							while (true)
							{
								switch (num3)
								{
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
									if (num2 != 1)
									{
										num = 3;
										num3 = num;
										continue;
									}
									awaiter = eval_p;
									eval_p = default(TaskAwaiter);
									num2 = (eval_a = -1);
									num = 7;
									num3 = num;
									continue;
								case 4:
									if (!awaiter.IsCompleted)
									{
										num = 0;
										num3 = num;
										continue;
									}
									goto case 7;
								case 7:
									awaiter.GetResult();
									num = 6;
									num3 = num;
									continue;
								case 3:
									num = 9;
									num3 = num;
									continue;
								case 6:
								case 9:
									num = 10;
									num3 = num;
									continue;
								case 10:
									if (eval_o.MoveNext())
									{
										TorrentManager current2 = eval_o.Current;
										current2.PeerConnected += (object A_0, [global::eval_b(1)] PeerConnectedEventArgs A_1) =>
										{
											short num18 = 14302;
											short num19 = num18;
											num18 = 14302;
											switch (num19 == num18)
											{
											default:
												num18 = 0;
												_ = num18;
												break;
											case true:
												break;
											case false:
											case true:
												return;
											}
											num18 = 1;
											if (num18 != 0)
											{
											}
											num18 = 0;
											if (num18 != 0)
											{
											}
											Top10Listener obj4 = CS_0024_003C_003E8__locals0.Listener;
											bool lockTaken4 = false;
											try
											{
												int num20 = default(int);
												switch (0)
												{
												default:
													while (true)
													{
														switch (num20)
														{
														case 1:
														{
															StatusMessageEventHandler statusMessageEventHandler4 = StandardDownloader.m_eval_a;
															if (statusMessageEventHandler4 == null)
															{
																num18 = 0;
																num20 = num18;
															}
															else
															{
																statusMessageEventHandler4(CS_0024_003C_003E8__locals0, "DownloadAsync," + $"Connection succeeded: {A_1.Peer.Uri}");
																num18 = 2;
																num20 = num18;
															}
															continue;
														}
														case 0:
															return;
														case 2:
															return;
														}
														break;
													}
													goto case 0;
												case 0:
													Monitor.Enter(obj4, ref lockTaken4);
													CS_0024_003C_003E8__locals0.Listener.WriteLine($"Connection succeeded: {A_1.Peer.Uri}");
													num18 = 1;
													num20 = num18;
													goto default;
												}
											}
											finally
											{
												num18 = 1;
												int num20 = num18;
												while (true)
												{
													switch (num20)
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
														if (lockTaken4)
														{
															num18 = 0;
															num20 = num18;
															continue;
														}
														break;
													case 0:
														Monitor.Exit(obj4);
														num18 = 2;
														num20 = num18;
														continue;
													case 2:
														break;
													}
													break;
												}
											}
										};
										current2.ConnectionAttemptFailed += (object A_0, [global::eval_b(1)] ConnectionAttemptFailedEventArgs A_1) =>
										{
											short num15 = -24990;
											short num16 = num15;
											num15 = -24990;
											switch (num16 == num15)
											{
											default:
												num15 = 0;
												_ = num15;
												break;
											case true:
												break;
											case false:
											case true:
												return;
											}
											num15 = 1;
											if (num15 != 0)
											{
											}
											num15 = 0;
											if (num15 != 0)
											{
											}
											Top10Listener obj3 = CS_0024_003C_003E8__locals0.Listener;
											bool lockTaken3 = false;
											try
											{
												int num17 = default(int);
												switch (0)
												{
												default:
													while (true)
													{
														switch (num17)
														{
														case 1:
														{
															StatusMessageEventHandler statusMessageEventHandler3 = StandardDownloader.m_eval_a;
															if (statusMessageEventHandler3 == null)
															{
																num15 = 0;
																num17 = num15;
															}
															else
															{
																statusMessageEventHandler3(CS_0024_003C_003E8__locals0, "DownloadAsync," + $"Connection failed: {A_1.Peer.ConnectionUri} - {A_1.Reason}");
																num15 = 2;
																num17 = num15;
															}
															continue;
														}
														case 0:
															return;
														case 2:
															return;
														}
														break;
													}
													goto case 0;
												case 0:
													Monitor.Enter(obj3, ref lockTaken3);
													CS_0024_003C_003E8__locals0.Listener.WriteLine($"Connection failed: {A_1.Peer.ConnectionUri} - {A_1.Reason}");
													num15 = 1;
													num17 = num15;
													goto default;
												}
											}
											finally
											{
												num15 = 1;
												int num17 = num15;
												while (true)
												{
													switch (num17)
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
														if (lockTaken3)
														{
															num15 = 0;
															num17 = num15;
															continue;
														}
														break;
													case 0:
														Monitor.Exit(obj3);
														num15 = 2;
														num17 = num15;
														continue;
													case 2:
														break;
													}
													break;
												}
											}
										};
										current2.PieceHashed += delegate(object A_0, PieceHashedEventArgs A_1)
										{
											short num12 = -7436;
											short num13 = num12;
											num12 = -7436;
											switch (num13 == num12)
											{
											default:
												num12 = 0;
												_ = num12;
												break;
											case true:
												break;
											case false:
											case true:
												return;
											}
											num12 = 1;
											if (num12 != 0)
											{
											}
											num12 = 0;
											if (num12 != 0)
											{
											}
											Top10Listener obj2 = CS_0024_003C_003E8__locals0.Listener;
											bool lockTaken2 = false;
											try
											{
												Monitor.Enter(obj2, ref lockTaken2);
												CS_0024_003C_003E8__locals0.Listener.WriteLine(string.Format("Piece Hashed: {0} - {1}", A_1.PieceIndex, A_1.HashPassed ? "Pass" : "Fail"));
											}
											finally
											{
												num12 = 1;
												int num14 = num12;
												while (true)
												{
													switch (num14)
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
														if (lockTaken2)
														{
															num12 = 0;
															num14 = num12;
															continue;
														}
														break;
													case 0:
														Monitor.Exit(obj2);
														num12 = 2;
														num14 = num12;
														continue;
													case 2:
														break;
													}
													break;
												}
											}
										};
										current2.TorrentStateChanged += delegate(object A_0, TorrentStateChangedEventArgs A_1)
										{
											short num9 = -7437;
											short num10 = num9;
											num9 = -7437;
											switch (num10 == num9)
											{
											default:
											{
												num9 = 0;
												_ = num9;
												num9 = 0;
												if (num9 != 0)
												{
												}
												Top10Listener obj = CS_0024_003C_003E8__locals0.Listener;
												bool lockTaken = false;
												try
												{
													int num11 = default(int);
													switch (0)
													{
													default:
														while (true)
														{
															switch (num11)
															{
															case 1:
															{
																StatusMessageEventHandler statusMessageEventHandler2 = StandardDownloader.m_eval_a;
																if (statusMessageEventHandler2 == null)
																{
																	num9 = 0;
																	num11 = num9;
																}
																else
																{
																	statusMessageEventHandler2(CS_0024_003C_003E8__locals0, "DownloadAsync," + $"OldState: {A_1.OldState} NewState: {A_1.NewState}");
																	num9 = 2;
																	num11 = num9;
																}
																continue;
															}
															case 0:
																return;
															case 2:
																num9 = 1;
																if (num9 == 0)
																{
																}
																return;
															}
															break;
														}
														goto case 0;
													case 0:
														Monitor.Enter(obj, ref lockTaken);
														CS_0024_003C_003E8__locals0.Listener.WriteLine($"OldState: {A_1.OldState} NewState: {A_1.NewState}");
														num9 = 1;
														num11 = num9;
														goto default;
													}
												}
												finally
												{
													num9 = 1;
													int num11 = num9;
													while (true)
													{
														switch (num11)
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
																num9 = 0;
																num11 = num9;
																continue;
															}
															break;
														case 0:
															Monitor.Exit(obj);
															num9 = 2;
															num11 = num9;
															continue;
														case 2:
															break;
														}
														break;
													}
												}
											}
											case false:
											case true:
												break;
											}
										};
										current2.TrackerManager.AnnounceComplete += (object A_0, [global::eval_b(1)] AnnounceResponseEventArgs A_1) =>
										{
											short num7 = -2289;
											short num8 = num7;
											num7 = -2289;
											switch (num8 == num7)
											{
											default:
												num7 = 0;
												_ = num7;
												num7 = 0;
												if (num7 != 0)
												{
												}
												num7 = 1;
												if (num7 != 0)
												{
												}
												CS_0024_003C_003E8__locals0.Listener.WriteLine($"{A_1.Successful}: {A_1.Tracker}");
												StandardDownloader.m_eval_a?.Invoke(CS_0024_003C_003E8__locals0, "DownloadAsync," + $"{A_1.Successful}: {A_1.Tracker}");
												break;
											}
										};
										awaiter = current2.StartAsync().GetAwaiter();
										num = 4;
										num3 = num;
									}
									else
									{
										num = 2;
										num3 = num;
									}
									continue;
								case 0:
								{
									num = -29404;
									short num4 = num;
									num = -29404;
									switch (num4 == num)
									{
									default:
										num = 0;
										if (num != 0)
										{
										}
										num2 = (eval_a = 1);
										eval_p = awaiter;
										eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
										break;
									case false:
									case true:
										break;
									}
									num = 1;
									num3 = num;
									continue;
								}
								case 1:
									break;
								case 2:
									num = 5;
									num3 = num;
									continue;
								case 5:
									goto IL_0d04;
								}
								break;
							}
						}
						finally
						{
							num = 2;
							num3 = num;
							while (true)
							{
								switch (num3)
								{
								case 2:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								default:
									if (num2 < 0)
									{
										num = 0;
										num3 = num;
										continue;
									}
									break;
								case 0:
									num = 3;
									num3 = num;
									continue;
								case 3:
									if (eval_o != null)
									{
										num = 4;
										num3 = num;
										continue;
									}
									break;
								case 4:
									eval_o.Dispose();
									num = 1;
									num3 = num;
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						goto end_IL_0075;
					case 17:
						num = 12;
						num3 = num;
						continue;
					case 12:
						if (CS_0024_003C_003E8__locals0.Engine.Torrents.Count == 0)
						{
							num = 2;
							num3 = num;
						}
						else
						{
							eval_o = CS_0024_003C_003E8__locals0.Engine.Torrents.GetEnumerator();
							num = 19;
							num3 = num;
						}
						continue;
					case 3:
						num2 = (eval_a = 2);
						eval_p = awaiter;
						eval_b.AwaitUnsafeOnCompleted(ref awaiter, ref this);
						num = 20;
						num3 = num;
						continue;
					case 20:
						goto end_IL_0075;
					case 2:
						num = 9;
						num3 = num;
						continue;
					case 5:
						awaiter.GetResult();
						num = 16;
						num3 = num;
						continue;
					case 22:
						goto IL_056e;
					case 16:
					case 23:
						num = 7;
						num3 = num;
						continue;
					case 7:
						if (CS_0024_003C_003E8__locals0.Engine.IsRunning)
						{
							num = 8;
							num3 = num;
							continue;
						}
						break;
					case 1:
						if (eval_k)
						{
							num = 17;
							num3 = num;
							continue;
						}
						break;
					case 18:
						try
						{
							num = 8;
							num3 = num;
							while (true)
							{
								switch (num3)
								{
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
									if (num2 != 0)
									{
										num = 3;
										num3 = num;
										continue;
									}
									goto case 0;
								case 0:
									num = 7;
									num3 = num;
									continue;
								case 7:
									try
									{
										num = 11;
										num3 = num;
										while (true)
										{
											switch (num3)
											{
											case 11:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											default:
												if (num2 != 0)
												{
													num = 5;
													num3 = num;
													continue;
												}
												awaiter2 = eval_n;
												eval_n = default(TaskAwaiter<TorrentManager>);
												num2 = (eval_a = -1);
												num = 7;
												num3 = num;
												continue;
											case 9:
												num2 = (eval_a = 0);
												eval_n = awaiter2;
												eval_b.AwaitUnsafeOnCompleted(ref awaiter2, ref this);
												num = 1;
												num3 = num;
												continue;
											case 1:
												break;
											case 5:
												num = 10;
												num3 = num;
												continue;
											case 10:
											{
												MD5CryptoServiceProvider mD5CryptoServiceProvider = new MD5CryptoServiceProvider();
												byte[] buffer = new byte[eval_m.Length];
												eval_m.Read(buffer, 0, (int)eval_m.Length);
												if (BitConverter.ToString(mD5CryptoServiceProvider.ComputeHash(buffer)).Replace("-", string.Empty).ToString() == d)
												{
													num = 2;
													num3 = num;
												}
												else
												{
													eval_l.Norificons("system:#N");
													num = 4;
													num3 = num;
												}
												continue;
											}
											case 2:
											{
												TorrentSettingsBuilder torrentSettingsBuilder = new TorrentSettingsBuilder
												{
													MaximumConnections = 500
												};
												awaiter2 = CS_0024_003C_003E8__locals0.Engine.AddAsync(eval_f, eval_g, torrentSettingsBuilder.ToSettings()).GetAwaiter();
												num = 3;
												num3 = num;
												continue;
											}
											case 3:
												if (!awaiter2.IsCompleted)
												{
													num = 9;
													num3 = num;
													continue;
												}
												goto case 7;
											case 7:
												result = awaiter2.GetResult();
												num = 12;
												num3 = num;
												continue;
											case 12:
											{
												StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
												if (statusMessageEventHandler != null)
												{
													statusMessageEventHandler(CS_0024_003C_003E8__locals0, "DownloadAsync,UPLOAD : " + result.InfoHashes.V1OrV2.ToHex());
													num = 0;
													num3 = num;
												}
												else
												{
													num = 6;
													num3 = num;
												}
												continue;
											}
											case 0:
											case 6:
												eval_k = true;
												eval_l.Norificons("system:#Y");
												num = 13;
												num3 = num;
												continue;
											case 4:
											case 13:
												num = 8;
												num3 = num;
												continue;
											case 8:
												goto IL_0b2e;
											}
											break;
										}
									}
									finally
									{
										num = 2;
										num3 = num;
										while (true)
										{
											switch (num3)
											{
											case 2:
												switch (0)
												{
												default:
													continue;
												case 0:
													break;
												}
												goto default;
											default:
												if (num2 < 0)
												{
													num = 0;
													num3 = num;
													continue;
												}
												break;
											case 0:
												num = 3;
												num3 = num;
												continue;
											case 3:
												if (eval_m != null)
												{
													num = 4;
													num3 = num;
													continue;
												}
												break;
											case 4:
												((IDisposable)eval_m).Dispose();
												num = 1;
												num3 = num;
												continue;
											case 1:
												break;
											}
											break;
										}
									}
									goto end_IL_0075;
								case 9:
									eval_m = File.OpenRead(Environment.CurrentDirectory + "\\data\\FILE.log");
									num = 0;
									num3 = num;
									continue;
								case 1:
									num = 6;
									num3 = num;
									continue;
								case 6:
									if (File.Exists(Environment.CurrentDirectory + "\\data\\FILE.log"))
									{
										num = 9;
										num3 = num;
										continue;
									}
									break;
								case 3:
									num = 2;
									num3 = num;
									continue;
								case 2:
									if (!File.Exists(Environment.CurrentDirectory + "\\cache\\fastresume\\" + eval_c + ".fresume"))
									{
										eval_l.Norificons("system:not found : " + eval_c + ".fresume");
										CS_0024_003C_003E8__locals0.StopedUpload();
										num = 4;
										num3 = num;
									}
									else
									{
										num = 1;
										num3 = num;
									}
									continue;
								case 4:
								case 10:
									break;
								case 5:
									goto end_IL_0650;
									IL_0b2e:
									eval_m = null;
									num = 10;
									num3 = num;
									continue;
								}
								num = 5;
								num3 = num;
								continue;
								end_IL_0650:
								break;
							}
						}
						catch (Exception ex)
						{
							eval_l.Norificons("system: #e " + eval_f);
							eval_l.Norificons("system: #e " + ex.Message);
							StandardDownloader.m_eval_a?.Invoke(CS_0024_003C_003E8__locals0, "DownloadAsync,UPLOAD : system: #e " + eval_f);
							StandardDownloader.m_eval_a?.Invoke(CS_0024_003C_003E8__locals0, "DownloadAsync,UPLOAD : system: #e " + ex.Message);
						}
						num = 1;
						num3 = num;
						continue;
					case 11:
						if (!awaiter.IsCompleted)
						{
							num = 3;
							num3 = num;
							continue;
						}
						goto case 5;
					case 19:
						goto IL_0ce6;
					case 8:
						num = 4;
						num3 = num;
						continue;
					case 4:
						if (eval_h)
						{
							num = 10;
							num3 = num;
						}
						else
						{
							enumerator = CS_0024_003C_003E8__locals0.Engine.Torrents.GetEnumerator();
							num = 6;
							num3 = num;
						}
						continue;
					case 6:
						try
						{
							num = 14;
							num3 = num;
							while (true)
							{
								switch (num3)
								{
								case 14:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								case 13:
									switch (state)
									{
									case TorrentState.Error:
										CS_0024_003C_003E8__locals0.StopedUpload();
										num = 8;
										num3 = num;
										continue;
									case TorrentState.Hashing:
										CS_0024_003C_003E8__locals0.StopedUpload();
										num = 2;
										num3 = num;
										continue;
									default:
										num = 9;
										num3 = num;
										continue;
									case TorrentState.Seeding:
										num = 6;
										num3 = num;
										continue;
									case TorrentState.Downloading:
										CS_0024_003C_003E8__locals0.StopedUpload();
										num = 5;
										num3 = num;
										continue;
									case TorrentState.Stopped:
									case TorrentState.Paused:
									case TorrentState.Starting:
									case TorrentState.HashingPaused:
									case TorrentState.Stopping:
									case TorrentState.Metadata:
									case TorrentState.FetchingHashes:
										break;
									}
									goto default;
								case 6:
									if (!(eval_i == "RU"))
									{
										eval_l.eval_f2.Content = "MONO (Game file distributionы) : " + CS_0024_003C_003E8__locals0.AllNumberToSpeed(current.Monitor.UploadRate, eval_i);
										num = 11;
										num3 = num;
									}
									else
									{
										num = 10;
										num3 = num;
									}
									continue;
								case 10:
									eval_l.eval_f2.Content = "MONO (Разадача файлов игры) : " + CS_0024_003C_003E8__locals0.AllNumberToSpeed(current.Monitor.UploadRate, eval_i);
									num = 12;
									num3 = num;
									continue;
								case 1:
									CS_0024_003C_003E8__locals0.StopedUpload();
									num = 15;
									num3 = num;
									continue;
								case 9:
									num = 4;
									num3 = num;
									continue;
								default:
									num = 16;
									num3 = num;
									continue;
								case 16:
									if (!enumerator.MoveNext())
									{
										num = 0;
										num3 = num;
									}
									else
									{
										current = enumerator.Current;
										num = 7;
										num3 = num;
									}
									continue;
								case 7:
									if (!eval_h)
									{
										_ = string.Empty;
										state = current.State;
										num = 13;
										num3 = num;
									}
									else
									{
										num = 1;
										num3 = num;
									}
									continue;
								case 0:
									num = 3;
									num3 = num;
									continue;
								case 3:
									break;
								}
								break;
							}
						}
						finally
						{
							num = 2;
							num3 = num;
							while (true)
							{
								switch (num3)
								{
								case 2:
									switch (0)
									{
									default:
										continue;
									case 0:
										break;
									}
									goto default;
								default:
									if (num2 < 0)
									{
										num = 0;
										num3 = num;
										continue;
									}
									break;
								case 1:
									enumerator.Dispose();
									num = 3;
									num3 = num;
									continue;
								case 3:
									break;
								case 0:
									num = 4;
									num3 = num;
									continue;
								case 4:
									if (enumerator != null)
									{
										num = 1;
										num3 = num;
										continue;
									}
									break;
								}
								break;
							}
						}
						CS_0024_003C_003E8__locals0.Listener.ExportTo(Console.Out);
						awaiter = Task.Delay(6000, j).GetAwaiter();
						num = 11;
						num3 = num;
						continue;
					case 10:
						break;
						IL_0d04:
						eval_o = null;
						num = 23;
						num3 = num;
						continue;
						IL_056e:
						num = 18;
						num3 = num;
						continue;
						IL_0ce6:
						num = 0;
						num3 = num;
						continue;
						IL_112e:
						awaiter = eval_p;
						eval_p = default(TaskAwaiter);
						num2 = (eval_a = -1);
						num = 5;
						num3 = num;
						continue;
					}
					num = 13;
					num3 = num;
					continue;
					end_IL_0095:
					break;
				}
				goto IL_0056;
				end_IL_0075:;
			}
			catch (Exception exception)
			{
				eval_a = -2;
				eval_l = null;
				eval_b.SetException(exception);
			}
			goto IL_120b;
			IL_120b:
			num = 1;
			if (num == 0)
			{
			}
			return;
			IL_0056:
			eval_a = -2;
			eval_l = null;
			eval_b.SetResult();
			goto IL_120b;
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in eval_d
			this.eval_d();
		}

		[DebuggerHidden]
		private void eval_d(IAsyncStateMachine A_0)
		{
			short num = 25158;
			short num2 = num;
			num = 25158;
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
			eval_b.SetStateMachine(A_0);
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine A_0)
		{
			//ILSpy generated this explicit interface implementation from .override directive in eval_d
			this.eval_d(A_0);
		}
	}

	[CompilerGenerated]
	private static StatusMessageEventHandler m_eval_a;

	[CompilerGenerated]
	private readonly ClientEngine m_eval_b;

	[CompilerGenerated]
	private readonly Top10Listener m_eval_c;

	private int m_eval_d;

	private ClientEngine Engine
	{
		[CompilerGenerated]
		get
		{
			short num = 8378;
			short num2 = num;
			num = 8378;
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
			return this.m_eval_b;
		}
	}

	private Top10Listener Listener
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
			num = 25045;
			short num2 = num;
			num = 25045;
			switch (num2 == num)
			{
			default:
				num = 0;
				if (num != 0)
				{
				}
				return this.m_eval_c;
			}
		}
	}

	public static event StatusMessageEventHandler StatusMessage
	{
		[CompilerGenerated]
		add
		{
			int num3 = default(int);
			StatusMessageEventHandler statusMessageEventHandler = default(StatusMessageEventHandler);
			short num;
			switch (0)
			{
			default:
			{
				StatusMessageEventHandler statusMessageEventHandler2 = default(StatusMessageEventHandler);
				while (true)
				{
					num = 16755;
					short num2 = num;
					num = 16755;
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
						statusMessageEventHandler2 = statusMessageEventHandler;
						StatusMessageEventHandler value2 = (StatusMessageEventHandler)Delegate.Combine(statusMessageEventHandler2, value);
						statusMessageEventHandler = Interlocked.CompareExchange(ref StandardDownloader.m_eval_a, value2, statusMessageEventHandler2);
						num = 1;
						num3 = num;
						continue;
					}
					case 1:
						num = 1;
						if (num != 0)
						{
						}
						num = 0;
						_ = num;
						if ((object)statusMessageEventHandler == statusMessageEventHandler2)
						{
							num = 2;
							num3 = num;
							continue;
						}
						goto case 0;
					case 2:
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
					statusMessageEventHandler = StandardDownloader.m_eval_a;
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
			StatusMessageEventHandler statusMessageEventHandler = default(StatusMessageEventHandler);
			short num;
			switch (0)
			{
			default:
			{
				StatusMessageEventHandler statusMessageEventHandler2 = default(StatusMessageEventHandler);
				while (true)
				{
					num = 31742;
					short num2 = num;
					num = 31742;
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
						statusMessageEventHandler2 = statusMessageEventHandler;
						StatusMessageEventHandler value2 = (StatusMessageEventHandler)Delegate.Remove(statusMessageEventHandler2, value);
						statusMessageEventHandler = Interlocked.CompareExchange(ref StandardDownloader.m_eval_a, value2, statusMessageEventHandler2);
						num = 1;
						num3 = num;
						continue;
					}
					case 1:
						if ((object)statusMessageEventHandler == statusMessageEventHandler2)
						{
							num = 0;
							_ = num;
							num = 1;
							if (num != 0)
							{
							}
							num = 2;
							num3 = num;
							continue;
						}
						goto case 0;
					case 2:
						return;
					}
					goto case 0;
					continue;
					end_IL_000a:
					break;
				}
				goto IL_006c;
			}
			case 0:
				{
					statusMessageEventHandler = StandardDownloader.m_eval_a;
					goto IL_006c;
				}
				IL_006c:
				num = 0;
				num3 = num;
				goto default;
			}
		}
	}

	public StandardDownloader(ClientEngine engine)
	{
		this.m_eval_b = engine;
		this.m_eval_c = new Top10Listener(10);
	}

	[AsyncStateMachine(typeof(eval_a))]
	public Task DownloadAsync(CancellationToken token, string torrentsPath, string downloadsPath, bool LoadResume, string Langve, bool UpdateStatus, bool DownloadAllGame, List<string> ListFileModsDownload, bool DownloadMods, bool CheckGameFileServer)
	{
		short num = -15799;
		short num2 = num;
		num = -15799;
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
		eval_a stateMachine = default(eval_a);
		stateMachine.eval_b = AsyncTaskMethodBuilder.Create();
		stateMachine.eval_c = this;
		stateMachine.m = token;
		stateMachine.eval_d = torrentsPath;
		stateMachine.eval_e = downloadsPath;
		stateMachine.eval_g = LoadResume;
		stateMachine.eval_k = Langve;
		stateMachine.eval_l = UpdateStatus;
		stateMachine.eval_f = DownloadAllGame;
		stateMachine.eval_i = ListFileModsDownload;
		stateMachine.eval_h = DownloadMods;
		stateMachine.eval_j = CheckGameFileServer;
		stateMachine.eval_a = -1;
		stateMachine.eval_b.Start(ref stateMachine);
		return stateMachine.eval_b.Task;
	}

	[AsyncStateMachine(typeof(eval_e))]
	public Task UploadAsync(CancellationToken token, string torrentsPath, string downloadsPath, string InfoHeshF, string Md5F, bool IfStopedUload, string Langve)
	{
		short num = -22442;
		short num2 = num;
		num = -22442;
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
		eval_e stateMachine = default(eval_e);
		stateMachine.eval_b = AsyncTaskMethodBuilder.Create();
		stateMachine.eval_e = this;
		stateMachine.j = token;
		stateMachine.eval_f = torrentsPath;
		stateMachine.eval_g = downloadsPath;
		stateMachine.eval_c = InfoHeshF;
		stateMachine.d = Md5F;
		stateMachine.eval_h = IfStopedUload;
		stateMachine.eval_i = Langve;
		stateMachine.eval_a = -1;
		stateMachine.eval_b.Start(ref stateMachine);
		return stateMachine.eval_b.Task;
	}

	[AsyncStateMachine(typeof(eval_b))]
	private void eval_b()
	{
		short num = 22546;
		short num2 = num;
		num = 22546;
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
		eval_b stateMachine = default(eval_b);
		stateMachine.eval_b = AsyncVoidMethodBuilder.Create();
		stateMachine.eval_c = this;
		stateMachine.eval_a = -1;
		stateMachine.eval_b.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(eval_d))]
	public void StopedUpload()
	{
		short num = 16358;
		short num2 = num;
		num = 16358;
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
		eval_d stateMachine = default(eval_d);
		stateMachine.eval_b = AsyncVoidMethodBuilder.Create();
		stateMachine.eval_c = this;
		stateMachine.eval_a = -1;
		stateMachine.eval_b.Start(ref stateMachine);
	}

	[AsyncStateMachine(typeof(eval_c))]
	private void eval_a()
	{
		short num = -23615;
		short num2 = num;
		num = -23615;
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
		eval_c stateMachine = default(eval_c);
		stateMachine.eval_b = AsyncVoidMethodBuilder.Create();
		stateMachine.eval_c = this;
		stateMachine.eval_a = -1;
		stateMachine.eval_b.Start(ref stateMachine);
	}

	public string AllNumberToSpeed(long value, string Langve)
	{
		short num = 0;
		switch (num)
		{
		default:
		{
			num = 2;
			int num2 = num;
			string[] array2 = default(string[]);
			string[] array = default(string[]);
			while (true)
			{
				switch (num2)
				{
				case 2:
					switch (0)
					{
					default:
						goto end_IL_003f;
					case 0:
						break;
					}
					goto default;
				default:
					if (Langve == "RU")
					{
						num = 28436;
						short num9 = num;
						num = 28436;
						switch (num9 == num)
						{
						default:
							num = 0;
							if (num != 0)
							{
							}
							num = 1;
							num2 = num;
							goto end_IL_003f;
						case false:
						case true:
							break;
						}
						goto IL_025b;
					}
					num = 1;
					if (num != 0)
					{
					}
					array2 = new string[7] { "b/s", "kB/s", "mB/s", "gB/s", "tB/s", "pB/s", "eB/s" };
					num = 0;
					_ = num;
					num = 0;
					num2 = num;
					break;
				case 0:
				{
					if (value == 0L)
					{
						num = 4;
						num2 = num;
						break;
					}
					long num6 = Math.Abs(value);
					int num7 = Convert.ToInt32(Math.Floor(Math.Log(num6, 1024.0)));
					double num8 = Math.Round((double)num6 / Math.Pow(1024.0, num7), 1);
					return string.Format(NumberFormatInfo.InvariantInfo, "{0:0.0} {1}", (double)Math.Sign(value) * num8, array2[num7]);
				}
				case 1:
					array = new string[7] { "б/с", "кб/с", "мб/с", "гб/с", "тб/с", "пб/с", "еб/с" };
					num = 3;
					num2 = num;
					break;
				case 3:
					if (value != 0L)
					{
						long num3 = Math.Abs(value);
						int num4 = Convert.ToInt32(Math.Floor(Math.Log(num3, 1024.0)));
						double num5 = Math.Round((double)num3 / Math.Pow(1024.0, num4), 1);
						return string.Format(NumberFormatInfo.InvariantInfo, "{0:0.0} {1}", (double)Math.Sign(value) * num5, array[num4]);
					}
					goto IL_025b;
				case 4:
					return "0 " + array2[0];
				case 5:
					{
						return "0 " + array[0];
					}
					IL_025b:
					num = 5;
					num2 = num;
					break;
					end_IL_003f:
					break;
				}
			}
		}
		}
	}

	public string TotalFile(long value, string Langve)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 0;
		switch (num)
		{
		default:
		{
			num = 2;
			int num2 = num;
			string[] array2 = default(string[]);
			string[] array = default(string[]);
			while (true)
			{
				switch (num2)
				{
				case 2:
					switch (0)
					{
					default:
						goto end_IL_0066;
					case 0:
						break;
					}
					goto default;
				default:
					if (Langve == "RU")
					{
						num = 4436;
						short num9 = num;
						num = 4436;
						switch (num9 == num)
						{
						default:
							num = 0;
							if (num != 0)
							{
							}
							num = 1;
							num2 = num;
							goto end_IL_0066;
						case false:
						case true:
							break;
						}
						goto IL_0258;
					}
					array2 = new string[7] { "B", "KB", "MB", "GB", "TB", "PB", "EB" };
					num = 0;
					_ = num;
					num = 0;
					num2 = num;
					break;
				case 0:
				{
					if (value == 0L)
					{
						num = 4;
						num2 = num;
						break;
					}
					long num6 = Math.Abs(value);
					int num7 = Convert.ToInt32(Math.Floor(Math.Log(num6, 1024.0)));
					double num8 = Math.Round((double)num6 / Math.Pow(1024.0, num7), 1);
					return string.Format(NumberFormatInfo.InvariantInfo, "{0:0.0} {1}", (double)Math.Sign(value) * num8, array2[num7]);
				}
				case 1:
					array = new string[7] { "Б", "КБ", "МБ", "ГБ", "ТБ", "ПБ", "ЕБ" };
					num = 3;
					num2 = num;
					break;
				case 3:
					if (value != 0L)
					{
						long num3 = Math.Abs(value);
						int num4 = Convert.ToInt32(Math.Floor(Math.Log(num3, 1024.0)));
						double num5 = Math.Round((double)num3 / Math.Pow(1024.0, num4), 1);
						return string.Format(NumberFormatInfo.InvariantInfo, "{0:0.0} {1}", (double)Math.Sign(value) * num5, array[num4]);
					}
					goto IL_0258;
				case 4:
					return "0 " + array2[0];
				case 5:
					{
						return "0 " + array[0];
					}
					IL_0258:
					num = 5;
					num2 = num;
					break;
					end_IL_0066:
					break;
				}
			}
		}
		}
	}

	public string TimeLeft(long speed, long totalsizes, long totaldownload, string Langve)
	{
		string result = default(string);
		short num;
		try
		{
			num = 0;
			switch (num)
			{
			default:
			{
				num = 15;
				int num2 = num;
				double num6 = default(double);
				string text = default(string);
				double val = default(double);
				double num8 = default(double);
				double num4 = default(double);
				double num5 = default(double);
				double num3 = default(double);
				while (true)
				{
					long num7;
					switch (num2)
					{
					case 15:
						switch (0)
						{
						default:
							continue;
						case 0:
							break;
						}
						goto default;
					default:
						if (speed != 0L)
						{
							num = 11;
							num2 = num;
						}
						else
						{
							num = 27;
							num2 = num;
						}
						continue;
					case 8:
					case 52:
						num = 45;
						num2 = num;
						continue;
					case 45:
						if (num6 > 0.0)
						{
							num = 26;
							num2 = num;
							continue;
						}
						goto case 16;
					case 5:
						num = 6;
						num2 = num;
						continue;
					case 6:
						if (Langve == "RU")
						{
							num = 3;
							num2 = num;
						}
						else
						{
							text = text + $"{Math.Max(1.0, val):00}" + " s. ";
							num = 28;
							num2 = num;
						}
						continue;
					case 35:
						text = text + num8 + " г. ";
						num = 8;
						num2 = num;
						continue;
					case 22:
						text += "00 м. ";
						num = 29;
						num2 = num;
						continue;
					case 28:
					case 39:
						num = 17;
						num2 = num;
						continue;
					case 17:
						if (text != null)
						{
							num = 42;
							num2 = num;
							continue;
						}
						break;
					case 2:
					case 46:
						num = 44;
						num2 = num;
						continue;
					case 44:
						if (num4 == 0.0)
						{
							num = 40;
							num2 = num;
							continue;
						}
						goto case 29;
					case 38:
						text = text + num6 + " м. ";
						num = 16;
						num2 = num;
						continue;
					case 3:
						text = text + $"{Math.Max(1.0, val):00}" + " с. ";
						num = 39;
						num2 = num;
						continue;
					case 21:
						text = text.Substring(0, text.Length - 1);
						num = 53;
						num2 = num;
						continue;
					case 37:
						text = text + num4 + " д. ";
						num = 10;
						num2 = num;
						continue;
					case 11:
						num = 23;
						num2 = num;
						continue;
					case 23:
						num7 = (totalsizes - totaldownload) / speed;
						goto IL_07be;
					case 26:
						num = 13;
						num2 = num;
						continue;
					case 13:
						if (Langve == "RU")
						{
							num = 38;
							num2 = num;
						}
						else
						{
							text = text + num6 + " m. ";
							num = 30;
							num2 = num;
						}
						continue;
					case 16:
					case 30:
						num = 12;
						num2 = num;
						continue;
					case 12:
						if (num4 > 0.0)
						{
							num = 18;
							num2 = num;
							continue;
						}
						goto case 7;
					case 4:
						text = text + $"{Math.Max(1.0, num5):00}" + " м. ";
						num = 43;
						num2 = num;
						continue;
					case 0:
						num = 50;
						num2 = num;
						continue;
					case 50:
					{
						if (!(Langve == "RU"))
						{
							text = text + num4 + " d. ";
							num = 7;
							num2 = num;
							continue;
						}
						num = -24376;
						short num9 = num;
						num = -24376;
						switch (num9 == num)
						{
						case false:
						case true:
							break;
						default:
							num = 0;
							if (num != 0)
							{
							}
							num = 37;
							num2 = num;
							continue;
						}
						goto IL_045b;
					}
					case 49:
						num = 41;
						num2 = num;
						continue;
					case 41:
						if (!(Langve == "RU"))
						{
							text += "00 m. ";
							num = 48;
							num2 = num;
						}
						else
						{
							num = 22;
							num2 = num;
						}
						continue;
					case 18:
						num = 32;
						num2 = num;
						continue;
					case 32:
						if (num8 == 0.0)
						{
							num = 0;
							num2 = num;
							continue;
						}
						goto case 7;
					case 9:
						num = 1;
						num2 = num;
						continue;
					case 1:
						if (Langve == "RU")
						{
							num = 35;
							num2 = num;
							continue;
						}
						goto IL_045b;
					case 29:
					case 34:
					case 43:
					case 48:
						num = 14;
						num2 = num;
						continue;
					case 14:
						if (num4 == 0.0)
						{
							num = 5;
							num2 = num;
							continue;
						}
						goto case 28;
					case 7:
					case 10:
						num = 25;
						num2 = num;
						continue;
					case 25:
						if (num6 == 0.0)
						{
							num = 19;
							num2 = num;
							continue;
						}
						goto case 2;
					case 20:
						if (num8 > 0.0)
						{
							num = 9;
							num2 = num;
							continue;
						}
						goto case 8;
					case 40:
						num = 31;
						num2 = num;
						continue;
					case 31:
						if (num5 == 0.0)
						{
							num = 49;
							num2 = num;
						}
						else
						{
							num = 33;
							num2 = num;
						}
						continue;
					case 27:
						num7 = 0L;
						goto IL_07be;
					case 33:
						if (Langve == "RU")
						{
							num = 4;
							num2 = num;
						}
						else
						{
							text = text + $"{Math.Max(1.0, num5):00}" + " m. ";
							num = 34;
							num2 = num;
						}
						continue;
					case 51:
						text = text + $"{num3:00}" + " ч. ";
						num = 46;
						num2 = num;
						continue;
					case 42:
						num = 24;
						num2 = num;
						continue;
					case 24:
						if (text.Length > 1)
						{
							num = 21;
							num2 = num;
							continue;
						}
						break;
					case 19:
						num = 47;
						num2 = num;
						continue;
					case 47:
						if (!(Langve == "RU"))
						{
							text = text + $"{num3:00}" + " h. ";
							num = 2;
							num2 = num;
						}
						else
						{
							num = 51;
							num2 = num;
						}
						continue;
					case 53:
						break;
					case 36:
						goto end_IL_003c;
						IL_045b:
						text = text + num8 + " y. ";
						num = 52;
						num2 = num;
						continue;
						IL_07be:
						val = Math.Ceiling((double)num7 % 60.0);
						num5 = Math.Floor((double)num7 / 60.0 % 60.0);
						num3 = Math.Floor((double)num7 / 60.0 / 60.0 % 60.0);
						num4 = Math.Floor((double)num7 / 60.0 / 60.0 / 60.0 % 24.0);
						num6 = Math.Floor((double)num7 / 60.0 / 60.0 / 60.0 / 24.0 % 30.5);
						num8 = Math.Floor((double)num7 / 60.0 / 60.0 / 60.0 / 24.0 / 30.5 % 12.0);
						text = "";
						num = 20;
						num2 = num;
						continue;
					}
					result = text;
					num = 36;
					num2 = num;
					continue;
					end_IL_003c:
					break;
				}
				break;
			}
			}
		}
		catch
		{
			result = "N/A";
		}
		num = 0;
		_ = num;
		num = 1;
		if (num != 0)
		{
		}
		return result;
	}

	private void eval_a(object A_0, PeersAddedEventArgs A_1)
	{
		short num = -32128;
		short num2 = num;
		num = -32128;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			break;
		case true:
			break;
		case false:
		case true:
			return;
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		Top10Listener obj = Listener;
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
					case 1:
					{
						StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler == null)
						{
							num = 0;
							num3 = num;
						}
						else
						{
							statusMessageEventHandler(this, "DownloadAsync," + $"Found {A_1.NewPeers} new peers and {A_1.ExistingPeers} existing peers");
							num = 2;
							num3 = num;
						}
						continue;
					}
					case 0:
						return;
					case 2:
						return;
					}
					break;
				}
				goto case 0;
			case 0:
				Monitor.Enter(obj, ref lockTaken);
				Listener.WriteLine($"Found {A_1.NewPeers} new peers and {A_1.ExistingPeers} existing peers");
				num = 1;
				num3 = num;
				goto default;
			}
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
						num = 0;
						num3 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
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

	[CompilerGenerated]
	private void eval_b(object A_0, [global::eval_b(1)] PeerConnectedEventArgs A_1)
	{
		short num = 12431;
		short num2 = num;
		num = 12431;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			break;
		case true:
			break;
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
		Top10Listener obj = Listener;
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
					case 1:
					{
						StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler == null)
						{
							num = 0;
							num3 = num;
						}
						else
						{
							statusMessageEventHandler(this, "DownloadAsync," + $"Connection succeeded: {A_1.Peer.Uri}");
							num = 2;
							num3 = num;
						}
						continue;
					}
					case 0:
						return;
					case 2:
						return;
					}
					break;
				}
				goto case 0;
			case 0:
				Monitor.Enter(obj, ref lockTaken);
				Listener.WriteLine($"Connection succeeded: {A_1.Peer.Uri}");
				num = 1;
				num3 = num;
				goto default;
			}
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
						num = 0;
						num3 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
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

	[CompilerGenerated]
	private void eval_b(object A_0, [global::eval_b(1)] ConnectionAttemptFailedEventArgs A_1)
	{
		short num = -24156;
		short num2 = num;
		num = -24156;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			break;
		case true:
			break;
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
		Top10Listener obj = Listener;
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
					case 1:
					{
						StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler == null)
						{
							num = 0;
							num3 = num;
						}
						else
						{
							statusMessageEventHandler(this, "DownloadAsync," + $"Connection failed: {A_1.Peer.ConnectionUri} - {A_1.Reason}");
							num = 2;
							num3 = num;
						}
						continue;
					}
					case 0:
						return;
					case 2:
						return;
					}
					break;
				}
				goto case 0;
			case 0:
				Monitor.Enter(obj, ref lockTaken);
				Listener.WriteLine($"Connection failed: {A_1.Peer.ConnectionUri} - {A_1.Reason}");
				num = 1;
				num3 = num;
				goto default;
			}
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
						num = 0;
						num3 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
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

	[CompilerGenerated]
	private void eval_b(object A_0, PieceHashedEventArgs A_1)
	{
		short num = 14618;
		short num2 = num;
		num = 14618;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			break;
		case true:
			break;
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
		Top10Listener obj = Listener;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			Listener.WriteLine(string.Format("Piece Hashed: {0} - {1}", A_1.PieceIndex, A_1.HashPassed ? "Pass" : "Fail"));
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
						num = 0;
						num3 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
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

	[CompilerGenerated]
	private void eval_b(object A_0, TorrentStateChangedEventArgs A_1)
	{
		short num = 272;
		short num2 = num;
		num = 272;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			break;
		case true:
			break;
		case false:
		case true:
			return;
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		Top10Listener obj = Listener;
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
					case 1:
					{
						StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler == null)
						{
							num = 0;
							num3 = num;
						}
						else
						{
							statusMessageEventHandler(this, "DownloadAsync," + $"OldState: {A_1.OldState} NewState: {A_1.NewState}");
							num = 2;
							num3 = num;
						}
						continue;
					}
					case 0:
						return;
					case 2:
						return;
					}
					break;
				}
				goto case 0;
			case 0:
				Monitor.Enter(obj, ref lockTaken);
				Listener.WriteLine($"OldState: {A_1.OldState} NewState: {A_1.NewState}");
				num = 1;
				num3 = num;
				goto default;
			}
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
						num = 0;
						num3 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
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

	[CompilerGenerated]
	private void eval_b(object A_0, [global::eval_b(1)] AnnounceResponseEventArgs A_1)
	{
		short num = -27692;
		short num2 = num;
		num = -27692;
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
		Listener.WriteLine($"{A_1.Successful}: {A_1.Tracker}");
		StandardDownloader.m_eval_a?.Invoke(this, "DownloadAsync," + $"{A_1.Successful}: {A_1.Tracker}");
	}

	[CompilerGenerated]
	private void eval_a(object A_0, [global::eval_b(1)] PeerConnectedEventArgs A_1)
	{
		short num = 14302;
		short num2 = num;
		num = 14302;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			break;
		case true:
			break;
		case false:
		case true:
			return;
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		Top10Listener obj = Listener;
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
					case 1:
					{
						StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler == null)
						{
							num = 0;
							num3 = num;
						}
						else
						{
							statusMessageEventHandler(this, "DownloadAsync," + $"Connection succeeded: {A_1.Peer.Uri}");
							num = 2;
							num3 = num;
						}
						continue;
					}
					case 0:
						return;
					case 2:
						return;
					}
					break;
				}
				goto case 0;
			case 0:
				Monitor.Enter(obj, ref lockTaken);
				Listener.WriteLine($"Connection succeeded: {A_1.Peer.Uri}");
				num = 1;
				num3 = num;
				goto default;
			}
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
						num = 0;
						num3 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
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

	[CompilerGenerated]
	private void eval_a(object A_0, [global::eval_b(1)] ConnectionAttemptFailedEventArgs A_1)
	{
		short num = -24990;
		short num2 = num;
		num = -24990;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			break;
		case true:
			break;
		case false:
		case true:
			return;
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		Top10Listener obj = Listener;
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
					case 1:
					{
						StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler == null)
						{
							num = 0;
							num3 = num;
						}
						else
						{
							statusMessageEventHandler(this, "DownloadAsync," + $"Connection failed: {A_1.Peer.ConnectionUri} - {A_1.Reason}");
							num = 2;
							num3 = num;
						}
						continue;
					}
					case 0:
						return;
					case 2:
						return;
					}
					break;
				}
				goto case 0;
			case 0:
				Monitor.Enter(obj, ref lockTaken);
				Listener.WriteLine($"Connection failed: {A_1.Peer.ConnectionUri} - {A_1.Reason}");
				num = 1;
				num3 = num;
				goto default;
			}
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
						num = 0;
						num3 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
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

	[CompilerGenerated]
	private void eval_a(object A_0, PieceHashedEventArgs A_1)
	{
		short num = -7436;
		short num2 = num;
		num = -7436;
		switch (num2 == num)
		{
		default:
			num = 0;
			_ = num;
			break;
		case true:
			break;
		case false:
		case true:
			return;
		}
		num = 1;
		if (num != 0)
		{
		}
		num = 0;
		if (num != 0)
		{
		}
		Top10Listener obj = Listener;
		bool lockTaken = false;
		try
		{
			Monitor.Enter(obj, ref lockTaken);
			Listener.WriteLine(string.Format("Piece Hashed: {0} - {1}", A_1.PieceIndex, A_1.HashPassed ? "Pass" : "Fail"));
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
						num = 0;
						num3 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
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

	[CompilerGenerated]
	private void eval_a(object A_0, TorrentStateChangedEventArgs A_1)
	{
		short num = -7437;
		short num2 = num;
		num = -7437;
		switch (num2 == num)
		{
		case false:
		case true:
			return;
		}
		num = 0;
		_ = num;
		num = 0;
		if (num != 0)
		{
		}
		Top10Listener obj = Listener;
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
					case 1:
					{
						StatusMessageEventHandler statusMessageEventHandler = StandardDownloader.m_eval_a;
						if (statusMessageEventHandler == null)
						{
							num = 0;
							num3 = num;
						}
						else
						{
							statusMessageEventHandler(this, "DownloadAsync," + $"OldState: {A_1.OldState} NewState: {A_1.NewState}");
							num = 2;
							num3 = num;
						}
						continue;
					}
					case 0:
						return;
					case 2:
						num = 1;
						if (num == 0)
						{
						}
						return;
					}
					break;
				}
				goto case 0;
			case 0:
				Monitor.Enter(obj, ref lockTaken);
				Listener.WriteLine($"OldState: {A_1.OldState} NewState: {A_1.NewState}");
				num = 1;
				num3 = num;
				goto default;
			}
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
						num = 0;
						num3 = num;
						continue;
					}
					break;
				case 0:
					Monitor.Exit(obj);
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

	[CompilerGenerated]
	private void eval_a(object A_0, [global::eval_b(1)] AnnounceResponseEventArgs A_1)
	{
		short num = -2289;
		short num2 = num;
		num = -2289;
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
		Listener.WriteLine($"{A_1.Successful}: {A_1.Tracker}");
		StandardDownloader.m_eval_a?.Invoke(this, "DownloadAsync," + $"{A_1.Successful}: {A_1.Tracker}");
	}
}
