namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneBattleInfo
	{
		[ProtoMember(1)] public List<BattleAvatar> BattleAvatarList;
		[ProtoMember(14)] public int RoundsLimit;
		[ProtoMember(11)] public List<int> AKMCAFABELI;
		[ProtoMember(9)] public List<BattleBuff> BuffList;
		[ProtoMember(3)] public List<GIOMKGLAEHG> HEFBEDPNADM;
		[ProtoMember(7)] public int LogicRandomSeed;
		[ProtoMember(15)] public int BattleId;
		[ProtoMember(13)] public CNEHJPFNJGL MechanismBarInfo;
		[ProtoMember(10)] public List<PDPCNJHHAJB> EJPPGOFMDOK;
		[ProtoMember(2)] public List<JBIFJJMLIML> FHDLDLDIFOJ;
		[ProtoMember(5)] public int StageId;
		[ProtoMember(150)] public List<ClientTurnSnapshot> TurnSnapshotList;
		[ProtoMember(6)] public int EBNJJADBHFN;
		[ProtoMember(12)] public int WorldLevel;
		[ProtoMember(8)] public List<SceneMonsterWave> MonsterWaveList;
	}
	
}
