namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Shop
	{
		[ProtoMember(12)] public int CityExp;
		[ProtoMember(7)] public long BeginTime;
		[ProtoMember(11)] public long EndTime;
		[ProtoMember(14)] public List<Goods> GoodsList;
		[ProtoMember(3)] public int CityLevel;
		[ProtoMember(8)] public int ShopId;
		[ProtoMember(2)] public long CityTakenLevelReward;
	}
	
}
