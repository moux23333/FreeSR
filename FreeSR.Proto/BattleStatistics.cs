namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleStatistics
	{
		[ProtoMember(1)] public int TotalBattleTurns;
		[ProtoMember(2)] public int TotalAutoTurns;
		[ProtoMember(3)] public List<int> AvatarIdList;
		[ProtoMember(4)] public int UltraCnt;
		[ProtoMember(5)] public double TotalDelayCumulate;
		[ProtoMember(6)] public double CostTime;
		[ProtoMember(7)] public List<AvatarBattleInfo> AvatarBattleList;
		[ProtoMember(8)] public List<MonsterBattleInfo> MonsterBattleList;
		[ProtoMember(9)] public int RoundCnt;
		[ProtoMember(10)] public int CocoonDeadWave;
		[ProtoMember(11)] public int AvatarBattleTurns;
		[ProtoMember(12)] public int MonsterBattleTurns;
		[ProtoMember(13)] public Dictionary<string,float> CustomValues;
		[ProtoMember(14)] public int ChallengeScore;
		[ProtoMember(16)] public List<ClientTurnSnapshot> JEPHGHBMMDN;
		[ProtoMember(17)] public CNEHJPFNJGL MechanismBarInfo;
		[ProtoMember(18)] public List<KLCOGJLHANM> JFHKDNNEAPG;
		[ProtoMember(19)] public AICGFNPLOJO NDDHLJNPJGD;
		[ProtoMember(20)] public List<JBIFJJMLIML> FHDLDLDIFOJ;
		[ProtoMember(21)] public List<KDEGCBHNGHN> KMKABKKPAFM;
		[ProtoMember(22)] public List<int> FIPDMCPFLBD;
		[ProtoMember(23)] public List<CNOLMEDHGDM> PLIBDGCOPAO;
		[ProtoMember(24)] public List<GIOMKGLAEHG> HEFBEDPNADM;
		[ProtoMember(25)] public List<PDPCNJHHAJB> EJPPGOFMDOK;
		[ProtoMember(26)] public List<OMDOHKAJOHH> GLMMGKPNMIK;
	}
	
}
