namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeChallengeTargetRewardScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(6)] public int ChallengeId;
		[ProtoMember(11)] public ItemList Reward;
		[ProtoMember(14)] public List<int> TakenIndexList;
	}
	
}
