using System;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace DamienG.Security.Cryptography;

public sealed class Crc322 : HashAlgorithm
{
	public const uint DefaultPolynomial = 3988292384u;

	public const uint DefaultSeed = uint.MaxValue;

	private static uint[] m_eval_a;

	private readonly uint b;

	private readonly uint[] c;

	private uint d;

	public override int HashSize
	{
		get
		{
			short num = 1;
			if (num != 0)
			{
			}
			num = 2902;
			short num2 = num;
			num = 2902;
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
			return 32;
		}
	}

	public Crc322()
		: this(3988292384u, uint.MaxValue)
	{
	}

	public Crc322(uint polynomial, uint seed)
	{
		c = eval_b(polynomial);
		b = (d = seed);
	}

	public override void Initialize()
	{
		short num = 30712;
		short num2 = num;
		num = 30712;
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
		d = b;
	}

	protected override void HashCore(byte[] array, int ibStart, int cbSize)
	{
		short num = 20761;
		short num2 = num;
		num = 20761;
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
		d = eval_a(c, d, array, ibStart, cbSize);
	}

	protected override byte[] HashFinal()
	{
		short num = -30357;
		short num2 = num;
		num = -30357;
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
			return HashValue = eval_a(~d);
		}
	}

	public static uint Compute(byte[] buffer)
	{
		short num = 11630;
		short num2 = num;
		num = 11630;
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
			return Compute(uint.MaxValue, buffer);
		}
	}

	public static uint Compute(uint seed, byte[] buffer)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 17665;
		short num2 = num;
		num = 17665;
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
		return Compute(3988292384u, seed, buffer);
	}

	public static uint Compute(uint polynomial, uint seed, byte[] buffer)
	{
		short num = 1;
		if (num != 0)
		{
		}
		num = 16697;
		short num2 = num;
		num = 16697;
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
		return ~eval_a(eval_b(polynomial), seed, buffer, 0, buffer.Length);
	}

	private static uint[] eval_b(uint A_0)
	{
		short num = 0;
		switch (num)
		{
		default:
		{
			num = 16;
			int num2 = num;
			uint[] array = default(uint[]);
			int num4 = default(int);
			uint num3 = default(uint);
			int num6 = default(int);
			while (true)
			{
				switch (num2)
				{
				case 16:
					switch (0)
					{
					default:
						continue;
					case 0:
						break;
					}
					goto default;
				default:
					if (A_0 == 3988292384u)
					{
						num = 17;
						num2 = num;
						continue;
					}
					goto IL_0126;
				case 4:
					array[num4] = num3;
					num4++;
					num = 18;
					num2 = num;
					continue;
				case 18:
					num = 1;
					if (num == 0)
					{
					}
					goto case 13;
				case 6:
					num = 8;
					num2 = num;
					continue;
				case 8:
					if (A_0 == 3988292384u)
					{
						num = 3;
						num2 = num;
						continue;
					}
					break;
				case 2:
					return Crc322.m_eval_a;
				case 5:
				case 15:
					num = 9;
					num2 = num;
					continue;
				case 9:
					if (num6 >= 8)
					{
						num = 4;
						num2 = num;
					}
					else
					{
						num = 11;
						num2 = num;
					}
					continue;
				case 3:
					Crc322.m_eval_a = array;
					num = 12;
					num2 = num;
					continue;
				case 1:
					num3 = (num3 >> 1) ^ A_0;
					num = 7;
					num2 = num;
					continue;
				case 13:
					num = 10;
					num2 = num;
					continue;
				case 10:
					if (num4 < 256)
					{
						num3 = (uint)num4;
						num6 = 0;
						num = 15;
						num2 = num;
					}
					else
					{
						num = 6;
						num2 = num;
					}
					continue;
				case 7:
				case 14:
					num6++;
					num = 5;
					num2 = num;
					continue;
				case 17:
					num = 0;
					num2 = num;
					continue;
				case 0:
					if (Crc322.m_eval_a != null)
					{
						num = 19769;
						short num5 = num;
						num = 19769;
						switch (num5 == num)
						{
						case false:
						case true:
							break;
						default:
							num = 0;
							if (num != 0)
							{
							}
							num = 2;
							num2 = num;
							continue;
						}
						goto case 4;
					}
					goto IL_0126;
				case 11:
					if ((num3 & 1) != 1)
					{
						num3 >>= 1;
						num = 14;
						num2 = num;
					}
					else
					{
						num = 1;
						num2 = num;
					}
					continue;
				case 12:
					break;
					IL_0126:
					array = new uint[256];
					num4 = 0;
					num = 13;
					num2 = num;
					continue;
				}
				break;
			}
			num = 0;
			_ = num;
			return array;
		}
		}
	}

	private static uint eval_a(uint[] A_0, uint A_1, IList<byte> A_2, int A_3, int A_4)
	{
		int num = default(int);
		int num5 = default(int);
		uint num2 = default(uint);
		switch (0)
		{
		default:
			while (true)
			{
				switch (num)
				{
				case 2:
				case 3:
				{
					short num3 = 0;
					num = num3;
					continue;
				}
				case 0:
				{
					short num3 = -32029;
					short num4 = num3;
					num3 = -32029;
					switch (num4 == num3)
					{
					default:
						num3 = 0;
						if (num3 != 0)
						{
						}
						if (num5 >= A_3 + A_4)
						{
							num3 = 1;
							num = num3;
							continue;
						}
						break;
					case false:
					case true:
						break;
					}
					num3 = 1;
					if (num3 != 0)
					{
					}
					num2 = (num2 >> 8) ^ A_0[A_2[num5] ^ (num2 & 0xFF)];
					num5++;
					num3 = 0;
					_ = num3;
					num3 = 2;
					num = num3;
					continue;
				}
				case 1:
					return num2;
				}
				break;
			}
			goto case 0;
		case 0:
		{
			num2 = A_1;
			num5 = A_3;
			short num3 = 3;
			num = num3;
			goto default;
		}
		}
	}

	private static byte[] eval_a(uint A_0)
	{
		int num = default(int);
		byte[] bytes = default(byte[]);
		switch (0)
		{
		default:
			while (true)
			{
				short num2;
				switch (num)
				{
				case 2:
				{
					num2 = -30890;
					short num3 = num2;
					num2 = -30890;
					switch (num3 == num2)
					{
					case false:
					case true:
						goto IL_00a6;
					}
					num2 = 0;
					if (num2 != 0)
					{
					}
					if (BitConverter.IsLittleEndian)
					{
						num2 = 0;
						num = num2;
						continue;
					}
					goto IL_00ef;
				}
				case 0:
					goto IL_00a6;
				case 1:
					{
						num2 = 0;
						_ = num2;
						goto IL_00ef;
					}
					IL_00a6:
					Array.Reverse(bytes);
					num2 = 1;
					num = num2;
					continue;
					IL_00ef:
					num2 = 1;
					if (num2 != 0)
					{
					}
					return bytes;
				}
				break;
			}
			goto case 0;
		case 0:
		{
			bytes = BitConverter.GetBytes(A_0);
			short num2 = 2;
			num = num2;
			goto default;
		}
		}
	}
}
