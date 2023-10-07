namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RechargeSuccNotify
	{
		[ProtoMember(6)] public long MonthCardOutdateTime;
		[ProtoMember(13)] public ItemList ItemList;
		[ProtoMember(1)] public string ProductId;
		[ProtoMember(7)] public string ChannelOrderNo;
	}

}
