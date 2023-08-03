namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetShopListCsReq
	{
		[ProtoMember(4)] public int ShopType;
	}
	
}
