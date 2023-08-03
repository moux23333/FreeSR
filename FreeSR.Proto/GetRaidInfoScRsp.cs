namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRaidInfoScRsp
	{
		[ProtoMember(2)] public List<NBOIGCKADPA> FinishedRaidInfoList;
		[ProtoMember(5)] public List<int> ChallengeTakenRewardIdList;
		[ProtoMember(7)] public List<ChallengeRaid> ChallengeRaidList;
		[ProtoMember(8)] public int Retcode;
	}
	
}
