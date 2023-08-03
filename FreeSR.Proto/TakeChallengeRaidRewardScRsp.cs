namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeChallengeRaidRewardScRsp
	{
		[ProtoMember(7)] public int RewardId;
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(8)] public ItemList Reward;
	}
	
}
