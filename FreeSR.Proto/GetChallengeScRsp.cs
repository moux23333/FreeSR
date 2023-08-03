namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetChallengeScRsp
	{
		[ProtoMember(5)] public List<Challenge> ChallengeList;
		[ProtoMember(6)] public List<OLHLPDGKEMI> PFAJEGIDEIP;
		[ProtoMember(14)] public int Retcode;
	}
	
}
