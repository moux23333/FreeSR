namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class IHJLINDHLFC
	{
		[ProtoMember(1)] public int Version;
		[ProtoMember(2)] public int LogicRandomSeed;
		[ProtoMember(3)] public int StageId;
		[ProtoMember(4)] public BattleLineup Lineup;
		[ProtoMember(5)] public List<BattleOp> OpList;
		[ProtoMember(6)] public byte[] TurnSnapshotHash;
		[ProtoMember(7)] public int MazePlaneId;
		[ProtoMember(8)] public List<int> ExtraAbilityList;
		[ProtoMember(9)] public bool IsAiConsiderUltraSkill;
		[ProtoMember(10)] public BattleCheckStrategyType CheckStrategy;
		[ProtoMember(11)] public BattleModuleType Type;
		[ProtoMember(12)] public List<ClientTurnSnapshot> TurnSnapshotList;
		[ProtoMember(13)] public CNEHJPFNJGL MechanismBarInfo;
		[ProtoMember(14)] public int RoundsLimit;
		[ProtoMember(15)] public OEEPAGHOAJG FKGHFCBLHAG;
		[ProtoMember(16)] public byte[] Data;
		[ProtoMember(17)] public int ClientVersion;
		[ProtoMember(18)] public int EBNJJADBHFN;
		[ProtoMember(100)] public GCLHGDBCFHJ HKENDCBGEBL;
	}
	
}
