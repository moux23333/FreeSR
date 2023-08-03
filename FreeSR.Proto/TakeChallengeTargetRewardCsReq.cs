namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeChallengeTargetRewardCsReq
	{
		[ProtoMember(9)] public int ChallengeId;
		[ProtoMember(14)] public List<int> IndexList;
	}
	
}
