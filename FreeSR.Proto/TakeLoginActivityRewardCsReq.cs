namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeLoginActivityRewardCsReq
	{
		[ProtoMember(9)] public int Id;
		[ProtoMember(11)] public int TakeDays;
	}
	
}
