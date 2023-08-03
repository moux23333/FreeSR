namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartBoxingClubBattleCsReq
	{
		[ProtoMember(7)] public int ChallengeId;
	}
	
}
