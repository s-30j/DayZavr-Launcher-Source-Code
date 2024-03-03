using System.Collections.ObjectModel;
using Torrentific.Core.Models;

namespace DataGridDemo;

public class ViewModel
{
	public static ObservableCollection<TorrentFileEntity> _orders;

	public ObservableCollection<TorrentFileEntity> Orders
	{
		get
		{
			short num = -5426;
			short num2 = num;
			num = -5426;
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
			return _orders;
		}
		set
		{
			short num = -820;
			short num2 = num;
			num = -820;
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
			_orders = value;
		}
	}

	public ViewModel()
	{
		_orders = new ObservableCollection<TorrentFileEntity>();
	}
}
