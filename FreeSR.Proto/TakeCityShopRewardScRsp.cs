namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeCityShopRewardScRsp
	{
		[ProtoMember(4)] public ItemList Reward;
		[ProtoMember(10)] public int ShopId;
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(6)] public int Level;
	}

}
