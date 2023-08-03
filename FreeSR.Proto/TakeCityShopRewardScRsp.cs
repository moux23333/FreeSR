namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeCityShopRewardScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(10)] public ItemList Reward;
		[ProtoMember(8)] public int ShopId;
		[ProtoMember(5)] public int Level;
	}
	
}
