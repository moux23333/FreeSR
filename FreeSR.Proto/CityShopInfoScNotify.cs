namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class CityShopInfoScNotify
	{
		[ProtoMember(11)] public long TakenLevelReward;
		[ProtoMember(9)] public int Exp;
		[ProtoMember(5)] public int Level;
		[ProtoMember(4)] public int ShopId;
	}
	
}
