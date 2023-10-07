namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetShopListScRsp
	{
		[ProtoMember(14)] public int ShopType;
		[ProtoMember(6)] public List<Shop> ShopList;
		[ProtoMember(10)] public int Retcode;
	}

}
