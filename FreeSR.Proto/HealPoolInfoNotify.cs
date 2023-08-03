namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HealPoolInfoNotify
	{
		[ProtoMember(2)] public HealPoolInfo HealPoolInfo;
	}
	
}
