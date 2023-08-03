namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Goods
	{
		[ProtoMember(2)] public long EndTime;
		[ProtoMember(14)] public long BeginTime;
		[ProtoMember(12)] public int BuyTimes;
		[ProtoMember(7)] public int ItemId;
		[ProtoMember(4)] public int GoodsId;
	}
	
}
