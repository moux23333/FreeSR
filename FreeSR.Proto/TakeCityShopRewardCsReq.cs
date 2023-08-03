namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeCityShopRewardCsReq
	{
		[ProtoMember(2)] public int GoodsId;
		[ProtoMember(8)] public int Level;
	}
	
}
