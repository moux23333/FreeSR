namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BlackInfo
	{
		[ProtoMember(1)] public long BeginTime;
		[ProtoMember(2)] public long EndTime;
		[ProtoMember(3)] public int LimitLevel;
		[ProtoMember(4)] public int BanType;
	}
	
}
