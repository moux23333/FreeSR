namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetShopListScRsp
	{
		[ProtoMember(8)] public List<Shop> ShopList;
		[ProtoMember(15)] public int ShopType;
		[ProtoMember(6)] public int Retcode;
	}
	
}
