namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class CityShopInfoScNotify
	{
		[ProtoMember(4)] public int Level;
		[ProtoMember(12)] public long TakenLevelReward;
		[ProtoMember(5)] public int ShopId;
		[ProtoMember(9)] public int Exp;
	}

}
