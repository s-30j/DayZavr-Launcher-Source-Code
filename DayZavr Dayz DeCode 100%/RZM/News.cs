using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Launcher;

namespace RZM;

public partial class News : UserControl, IComponentConnector
{
	[CompilerGenerated]
	private string _003CURL_003Ek__BackingField;

	internal News NewsControll;

	internal Grid GALLTXT;

	internal Label tbText_Headline;

	internal TextBlock tbText;

	internal Button BGo;

	internal Border BORDER_Copy1;

	internal Border BORDER;

	internal Border BORDER_Copy;

	private string URL
	{
		[CompilerGenerated]
		get
		{
			short num = 721;
			short num2 = num;
			num = 721;
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
				return _003CURL_003Ek__BackingField;
			}
		}
		[CompilerGenerated]
		set
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = -24646;
			short num2 = num;
			num = -24646;
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
			_003CURL_003Ek__BackingField = value;
		}
	}

	public string NewsText
	{
		get
		{
			short num = 24219;
			short num2 = num;
			num = 24219;
			switch (num2 == num)
			{
			default:
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
				return tbText.Text.ToString();
			}
		}
		set
		{
			short num = 12697;
			short num2 = num;
			num = 12697;
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
			tbText.Text = value;
		}
	}

	public string NewsTextHeadline
	{
		get
		{
			short num = -27016;
			short num2 = num;
			num = -27016;
			switch (num2 == num)
			{
			default:
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
				return tbText_Headline.Content.ToString();
			}
		}
		set
		{
			short num = -16475;
			short num2 = num;
			num = -16475;
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
			tbText_Headline.Content = value;
		}
	}

	public string NewsTexturl
	{
		get
		{
			short num = 8163;
			short num2 = num;
			num = 8163;
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
				return URL;
			}
		}
		set
		{
			short num = -30830;
			short num2 = num;
			num = -30830;
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
			URL = value;
		}
	}

	public string NewsIMAGE
	{
		set
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 32111;
			short num2 = num;
			num = 32111;
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
			eval_a(value);
		}
	}

	public int LineTXT
	{
		get
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 28348;
			short num2 = num;
			num = 28348;
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
			return (int)tbText.Height;
		}
		set
		{
			short num = 28185;
			short num2 = num;
			num = 28185;
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
			tbText.Height = value;
		}
	}

	public News()
	{
		InitializeComponent();
		try
		{
			foreach (FontFamily fontFamily in Fonts.GetFontFamilies(new Uri("pack://application:,,,/"), "./resources/fontm/"))
			{
				tbText_Headline.FontFamily = fontFamily;
				BGo.FontFamily = fontFamily;
			}
			foreach (FontFamily fontFamily2 in Fonts.GetFontFamilies(new Uri("pack://application:,,,/"), "./resources/fontn/"))
			{
				tbText.FontFamily = fontFamily2;
			}
		}
		catch
		{
		}
	}

	private void eval_a(string A_0)
	{
		short num;
		try
		{
			num = -14448;
			short num2 = num;
			num = -14448;
			switch (num2 == num)
			{
			default:
			{
				num = 0;
				if (num != 0)
				{
				}
				ImageBrush background = new ImageBrush
				{
					ImageSource = new BitmapImage(new Uri(A_0))
				};
				BORDER.Background = background;
				break;
			}
			}
		}
		catch
		{
		}
		num = 0;
		_ = num;
		num = 1;
		if (num == 0)
		{
		}
	}

	private void eval_c(object A_0, MouseButtonEventArgs A_1)
	{
		short num;
		try
		{
			num = 0;
			int num2 = num;
			switch (num2)
			{
			default:
			{
				num = -4797;
				short num3 = num;
				num = -4797;
				string fileName = default(string);
				StreamWriter streamWriter = default(StreamWriter);
				StreamReader streamReader = default(StreamReader);
				string text = default(string);
				switch (num3 == num)
				{
				default:
					num = 0;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_008a;
					}
					goto IL_0073;
				case false:
				case true:
					{
						Process.Start(fileName);
						num = 3;
						num2 = num;
						goto IL_0073;
					}
					IL_008a:
					num = 1;
					if (num != 0)
					{
					}
					fileName = string.Empty;
					streamWriter = new StreamWriter(MainWindow.DirLocal + "\\url");
					num = 0;
					num2 = num;
					goto IL_0073;
					IL_0073:
					while (true)
					{
						switch (num2)
						{
						case 0:
							try
							{
								streamWriter.WriteLine(URL);
								streamWriter.Close();
							}
							finally
							{
								num = 0;
								num2 = num;
								while (true)
								{
									switch (num2)
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
										if (streamWriter != null)
										{
											num = 1;
											num2 = num;
											continue;
										}
										break;
									case 1:
										((IDisposable)streamWriter).Dispose();
										num = 2;
										num2 = num;
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							streamReader = new StreamReader(MainWindow.DirLocal + "\\url");
							num = 2;
							num2 = num;
							continue;
						case 1:
							goto IL_0186;
						case 2:
							try
							{
								num = 1;
								num2 = num;
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
									case 3:
										if (!string.IsNullOrEmpty(text))
										{
											num = 4;
											num2 = num;
											continue;
										}
										goto default;
									default:
										num = 2;
										num2 = num;
										continue;
									case 2:
										if ((text = streamReader.ReadLine()) != null)
										{
											num = 3;
											num2 = num;
										}
										else
										{
											num = 0;
											num2 = num;
										}
										continue;
									case 4:
										fileName = text;
										num = 5;
										num2 = num;
										continue;
									case 0:
										streamReader.Close();
										num = 6;
										num2 = num;
										continue;
									case 6:
										break;
									}
									break;
								}
							}
							finally
							{
								num = 0;
								num2 = num;
								while (true)
								{
									switch (num2)
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
										if (streamReader != null)
										{
											num = 1;
											num2 = num;
											continue;
										}
										break;
									case 1:
										((IDisposable)streamReader).Dispose();
										num = 2;
										num2 = num;
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							num = 1;
							num2 = num;
							continue;
						case 3:
							goto end_IL_0041;
						}
						break;
					}
					goto IL_008a;
					IL_0186:
					try
					{
						num = 0;
						num2 = num;
						while (true)
						{
							switch (num2)
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
								if (File.Exists(MainWindow.DirLocal + "\\url"))
								{
									num = 1;
									num2 = num;
									continue;
								}
								break;
							case 1:
								File.Delete(MainWindow.DirLocal + "\\url");
								num = 2;
								num2 = num;
								continue;
							case 2:
								break;
							case 3:
								goto end_IL_01a6;
							}
							num = 3;
							num2 = num;
							continue;
							end_IL_01a6:
							break;
						}
					}
					catch
					{
					}
					goto case false;
					end_IL_0041:
					break;
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		num = 0;
		_ = num;
	}

	private void eval_b(object A_0, MouseEventArgs A_1)
	{
		short num = -5985;
		short num2 = num;
		num = -5985;
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
		BORDER_Copy.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#FF7C7C7C"));
	}

	private void eval_a(object A_0, MouseEventArgs A_1)
	{
		short num = 31342;
		short num2 = num;
		num = 31342;
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
		BORDER_Copy.Background = new SolidColorBrush(Colors.Transparent);
	}

	private void eval_b(object A_0, MouseButtonEventArgs A_1)
	{
		short num;
		try
		{
			num = 0;
			int num2 = num;
			switch (num2)
			{
			default:
			{
				StreamWriter streamWriter = default(StreamWriter);
				string fileName = default(string);
				switch (0)
				{
				default:
				{
					StreamReader streamReader = default(StreamReader);
					string text = default(string);
					while (true)
					{
						switch (num2)
						{
						case 1:
							try
							{
								streamWriter.WriteLine(URL);
								streamWriter.Close();
							}
							finally
							{
								num = 1;
								num2 = num;
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
										if (streamWriter != null)
										{
											num = 0;
											num2 = num;
											continue;
										}
										break;
									case 0:
										((IDisposable)streamWriter).Dispose();
										num = 2;
										num2 = num;
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							streamReader = new StreamReader(MainWindow.DirLocal + "\\url");
							num = 3;
							num2 = num;
							continue;
						case 2:
							try
							{
								num = 1;
								num2 = num;
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
										if (File.Exists(MainWindow.DirLocal + "\\url"))
										{
											num = 2;
											num2 = num;
											continue;
										}
										break;
									case 2:
									{
										File.Delete(MainWindow.DirLocal + "\\url");
										num = -24330;
										short num3 = num;
										num = -24330;
										switch (num3 == num)
										{
										default:
											num = 0;
											if (num != 0)
											{
											}
											num = 3;
											num2 = num;
											continue;
										case false:
										case true:
											break;
										}
										goto end_IL_012e;
									}
									case 3:
										break;
									case 0:
										goto end_IL_012e;
									}
									num = 0;
									num2 = num;
									continue;
									end_IL_012e:
									break;
								}
							}
							catch
							{
							}
							Process.Start(fileName);
							num = 0;
							num2 = num;
							continue;
						case 3:
							try
							{
								num = 4;
								num2 = num;
								while (true)
								{
									switch (num2)
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
									case 1:
										if (!string.IsNullOrEmpty(text))
										{
											num = 5;
											num2 = num;
											continue;
										}
										goto default;
									default:
										num = 0;
										num2 = num;
										continue;
									case 0:
										if ((text = streamReader.ReadLine()) != null)
										{
											num = 1;
											num2 = num;
										}
										else
										{
											num = 2;
											num2 = num;
										}
										continue;
									case 5:
										fileName = text;
										num = 6;
										num2 = num;
										continue;
									case 2:
										streamReader.Close();
										num = 3;
										num2 = num;
										continue;
									case 3:
										break;
									}
									break;
								}
							}
							finally
							{
								num = 1;
								num2 = num;
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
										if (streamReader != null)
										{
											num = 0;
											num2 = num;
											continue;
										}
										break;
									case 0:
										((IDisposable)streamReader).Dispose();
										num = 2;
										num2 = num;
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							num = 2;
							num2 = num;
							continue;
						case 0:
							goto end_IL_0028;
						}
						goto case 0;
						continue;
						end_IL_0028:
						break;
					}
					break;
				}
				case 0:
					fileName = string.Empty;
					streamWriter = new StreamWriter(MainWindow.DirLocal + "\\url");
					num = 1;
					num2 = num;
					goto default;
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		num = 0;
		_ = num;
		num = 1;
		if (num == 0)
		{
		}
	}

	private void eval_a(object A_0, MouseButtonEventArgs A_1)
	{
		short num;
		try
		{
			num = 0;
			int num2 = num;
			switch (num2)
			{
			default:
			{
				StreamWriter streamWriter = default(StreamWriter);
				string fileName = default(string);
				switch (0)
				{
				default:
				{
					StreamReader streamReader = default(StreamReader);
					string text = default(string);
					while (true)
					{
						switch (num2)
						{
						case 1:
							try
							{
								streamWriter.WriteLine(URL);
								streamWriter.Close();
							}
							finally
							{
								num = 1;
								num2 = num;
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
										if (streamWriter != null)
										{
											num = 0;
											num2 = num;
											continue;
										}
										break;
									case 0:
										((IDisposable)streamWriter).Dispose();
										num = 2;
										num2 = num;
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							streamReader = new StreamReader(MainWindow.DirLocal + "\\url");
							num = 3;
							num2 = num;
							continue;
						case 2:
							try
							{
								num = 1;
								if (num != 0)
								{
								}
								num = 1;
								num2 = num;
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
										if (File.Exists(MainWindow.DirLocal + "\\url"))
										{
											num = 2;
											num2 = num;
											continue;
										}
										break;
									case 2:
									{
										File.Delete(MainWindow.DirLocal + "\\url");
										num = 5834;
										short num3 = num;
										num = 5834;
										switch (num3 == num)
										{
										default:
											num = 0;
											if (num != 0)
											{
											}
											num = 3;
											num2 = num;
											continue;
										case false:
										case true:
											break;
										}
										goto end_IL_0159;
									}
									case 3:
										break;
									case 0:
										goto end_IL_0159;
									}
									num = 0;
									num2 = num;
									continue;
									end_IL_0159:
									break;
								}
							}
							catch
							{
							}
							Process.Start(fileName);
							num = 0;
							num2 = num;
							continue;
						case 3:
							try
							{
								num = 4;
								num2 = num;
								while (true)
								{
									switch (num2)
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
									case 1:
										if (!string.IsNullOrEmpty(text))
										{
											num = 5;
											num2 = num;
											continue;
										}
										goto default;
									default:
										num = 0;
										num2 = num;
										continue;
									case 0:
										if ((text = streamReader.ReadLine()) != null)
										{
											num = 1;
											num2 = num;
										}
										else
										{
											num = 2;
											num2 = num;
										}
										continue;
									case 5:
										fileName = text;
										num = 6;
										num2 = num;
										continue;
									case 2:
										streamReader.Close();
										num = 3;
										num2 = num;
										continue;
									case 3:
										break;
									}
									break;
								}
							}
							finally
							{
								num = 1;
								num2 = num;
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
										if (streamReader != null)
										{
											num = 0;
											num2 = num;
											continue;
										}
										break;
									case 0:
										((IDisposable)streamReader).Dispose();
										num = 2;
										num2 = num;
										continue;
									case 2:
										break;
									}
									break;
								}
							}
							num = 2;
							num2 = num;
							continue;
						case 0:
							goto end_IL_0028;
						}
						goto case 0;
						continue;
						end_IL_0028:
						break;
					}
					break;
				}
				case 0:
					fileName = string.Empty;
					streamWriter = new StreamWriter(MainWindow.DirLocal + "\\url");
					num = 1;
					num2 = num;
					goto default;
				}
				break;
			}
			}
		}
		catch (Exception ex)
		{
			MessageBox.Show(ex.Message);
		}
		num = 0;
		_ = num;
	}
}
