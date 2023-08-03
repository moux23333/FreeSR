namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HealPoolInfo
	{
		[ProtoMember(8)] public long RefreshTime;
		[ProtoMember(6)] public int HealPool;
	}
	
}
