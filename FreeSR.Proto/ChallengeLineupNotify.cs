namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ChallengeLineupNotify
	{
		[ProtoMember(3)] public ExtraLineupType ExtraLineupType;
	}
	
}
