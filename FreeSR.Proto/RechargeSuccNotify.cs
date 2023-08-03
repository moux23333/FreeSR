namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RechargeSuccNotify
	{
		[ProtoMember(12)] public long MonthCardOutdateTime;
		[ProtoMember(8)] public string ProductId;
		[ProtoMember(2)] public string ChannelOrderNo;
		[ProtoMember(5)] public ItemList ItemList;
	}
	
}
