namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MonsterBattleInfo
	{
		[ProtoMember(1)] public int EntityId;
		[ProtoMember(2)] public int MonsterId;
		[ProtoMember(3)] public int MonsterTemplateId;
		[ProtoMember(4)] public int MonsterLevel;
		[ProtoMember(5)] public MonsterProperty MonsterStatus;
		[ProtoMember(6)] public int TotalTurns;
		[ProtoMember(7)] public double TotalDamage;
		[ProtoMember(8)] public double TotalHeal;
		[ProtoMember(9)] public double TotalDamageTaken;
		[ProtoMember(10)] public double TotalStanceDamageTaken;
		[ProtoMember(11)] public double TotalHpRecover;
		[ProtoMember(12)] public int StageId;
		[ProtoMember(13)] public int BattleId;
		[ProtoMember(14)] public int MonsterType;
		[ProtoMember(15)] public List<AttackDamageProperty> AttackTypeDamage;
		[ProtoMember(16)] public List<SkillUseProperty> SkillTimes;
		[ProtoMember(17)] public int StageType;
		[ProtoMember(18)] public double TotalBreakDamageTaken;
		[ProtoMember(19)] public double DelayCumulate;
		[ProtoMember(20)] public DeathSource DeathSource;
		[ProtoMember(21)] public int Wave;
		[ProtoMember(22)] public int IndexInWave;
		[ProtoMember(23)] public int Phase;
		[ProtoMember(24)] public int MaxPhase;
		[ProtoMember(25)] public BattleTag BattleTag;
		[ProtoMember(26)] public List<LKLPOEPPEHP> OCCBKAINDCD;
	}
	
}
