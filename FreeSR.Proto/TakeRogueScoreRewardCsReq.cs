namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeRogueScoreRewardCsReq
	{
		[ProtoMember(13)] public int ECJCMODPEFI;
		[ProtoMember(15)] public List<int> BPKFCCAHBEG;
	}
	
}
