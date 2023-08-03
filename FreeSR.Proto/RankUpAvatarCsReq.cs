namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RankUpAvatarCsReq
	{
		[ProtoMember(9)] public ItemCostData CostData;
		[ProtoMember(4)] public int Rank;
		[ProtoMember(10)] public int BaseAvatarId;
	}
	
}
