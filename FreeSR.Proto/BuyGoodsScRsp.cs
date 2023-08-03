namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BuyGoodsScRsp
	{
		[ProtoMember(1)] public int GoodsId;
		[ProtoMember(14)] public int GoodsBuyTimes;
		[ProtoMember(9)] public ItemList ReturnItemList;
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(11)] public int ShopId;
	}
	
}
