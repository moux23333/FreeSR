namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ChallengeRaid
	{
		[ProtoMember(1)] public int RaidId;
		[ProtoMember(13)] public int MaxScore;
	}
	
}
