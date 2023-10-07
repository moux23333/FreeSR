namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Shop
	{
		[ProtoMember(5)] public int CityExp;
		[ProtoMember(8)] public int CityLevel;
		[ProtoMember(3)] public List<Goods> GoodsList;
		[ProtoMember(1)] public long BeginTime;
		[ProtoMember(6)] public int ShopId;
		[ProtoMember(2)] public long EndTime;
		[ProtoMember(14)] public long CityTakenLevelReward;
	}

}
