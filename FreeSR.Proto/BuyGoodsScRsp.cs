namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BuyGoodsScRsp
	{
		[ProtoMember(4)] public int ShopId;
		[ProtoMember(14)] public int GoodsBuyTimes;
		[ProtoMember(7)] public ItemList ReturnItemList;
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(10)] public int GoodsId;
	}

}
