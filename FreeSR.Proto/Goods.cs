namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Goods
	{
		[ProtoMember(10)] public int ItemId;
		[ProtoMember(7)] public long EndTime;
		[ProtoMember(5)] public int GoodsId;
		[ProtoMember(14)] public int BuyTimes;
		[ProtoMember(12)] public long BeginTime;
	}

}
