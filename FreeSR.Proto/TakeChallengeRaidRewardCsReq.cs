namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeChallengeRaidRewardCsReq
	{
		[ProtoMember(6)] public int RewardId;
	}
	
}
