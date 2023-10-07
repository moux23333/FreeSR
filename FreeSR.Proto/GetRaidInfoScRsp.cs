namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetRaidInfoScRsp
	{
		[ProtoMember(2)] public List<ENOHGAPOFLA> FinishedRaidInfoList;
		[ProtoMember(3)] public List<int> ChallengeTakenRewardIdList;
		[ProtoMember(1)] public List<MGLHNEGFGGF> ChallengeRaidList;
		[ProtoMember(10)] public int Retcode;
	}

}
