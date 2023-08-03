namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartChallengeScRsp
	{
		[ProtoMember(11)] public CurChallenge CurChallenge;
		[ProtoMember(13)] public LineupInfo Lineup;
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(2)] public SceneInfo Scene;
	}
	
}
