namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetBoxingClubInfoScRsp
	{
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(5)] public List<HFHCBBGHNHJ> ChallengeList;
	}
	
}
