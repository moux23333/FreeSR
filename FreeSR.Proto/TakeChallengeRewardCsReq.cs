namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeChallengeRewardCsReq
	{
		[ProtoMember(4)] public int GroupId;
		[ProtoMember(3)] public int DIMJKAICMDD;
	}
	
}
