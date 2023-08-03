namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class CurChallenge
	{
		[ProtoMember(13)] public int MPNACGBHOGO;
		[ProtoMember(7)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(3)] public int PEBNFPLHBCO;
		[ProtoMember(8)] public List<KillMonster> KillMonsterList;
		[ProtoMember(4)] public ChallengeStatus Status;
		[ProtoMember(14)] public int ChallengeId;
	}
	
}
