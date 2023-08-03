namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartChallengeCsReq
	{
		[ProtoMember(12)] public int ChallengeId;
		[ProtoMember(4)] public int ShopId;
	}
	
}
