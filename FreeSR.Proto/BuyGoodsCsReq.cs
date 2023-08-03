namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BuyGoodsCsReq
	{
		[ProtoMember(15)] public int ItemId;
		[ProtoMember(14)] public int GoodsId;
		[ProtoMember(11)] public int GNFCCAGCDFK;
		[ProtoMember(8)] public int ShopId;
		[ProtoMember(1)] public int FAMLHOHDCOI;
	}
	
}
