namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Challenge
	{
		[ProtoMember(15)] public int TakenReward;
		[ProtoMember(13)] public int Stars;
		[ProtoMember(14)] public int ChallengeId;
	}
	
}
