using System;
using System.Runtime.CompilerServices;

[eval_a]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
[CompilerGenerated]
internal sealed class eval_b : Attribute
{
	public readonly byte[] eval_a;

	public eval_b(byte A_0)
	{
		eval_a = new byte[1] { A_0 };
	}

	public eval_b(byte[] A_0)
	{
		eval_a = A_0;
	}
}
