namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartBoxingClubBattleScRsp
	{
		[ProtoMember(1)] public int ChallengeId;
		[ProtoMember(6)] public SceneBattleInfo BattleInfo;
		[ProtoMember(5)] public int Retcode;
	}
	
}
