namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AvatarBattleInfo
	{
		[ProtoMember(1)] public AvatarType AvatarType;
		[ProtoMember(2)] public int Id;
		[ProtoMember(3)] public int AvatarLevel;
		[ProtoMember(4)] public int AvatarRank;
		[ProtoMember(5)] public int AvatarPromotion;
		[ProtoMember(6)] public AvatarProperty AvatarStatus;
		[ProtoMember(7)] public List<AvatarSkillTree> AvatarSkill;
		[ProtoMember(8)] public List<EquipmentProperty> AvatarEquipment;
		[ProtoMember(9)] public int TotalTurns;
		[ProtoMember(10)] public double TotalDamage;
		[ProtoMember(11)] public double TotalHeal;
		[ProtoMember(12)] public double TotalDamageTaken;
		[ProtoMember(13)] public double TotalHpRecover;
		[ProtoMember(14)] public double TotalSpCost;
		[ProtoMember(15)] public int StageId;
		[ProtoMember(16)] public int StageType;
		[ProtoMember(17)] public double TotalBreakDamage;
		[ProtoMember(18)] public List<AttackDamageProperty> AttackTypeDamage;
		[ProtoMember(19)] public List<AttackDamageProperty> AttackTypeBreakDamage;
		[ProtoMember(20)] public List<AttackDamageProperty> AttackTypeMaxDamage;
		[ProtoMember(21)] public List<SkillUseProperty> SkillTimes;
		[ProtoMember(22)] public double DelayCumulate;
		[ProtoMember(23)] public int TotalSpAdd;
		[ProtoMember(24)] public List<SpAddSource> SpAddSource;
		[ProtoMember(25)] public int TotalBpCost;
		[ProtoMember(26)] public int DieTimes;
		[ProtoMember(27)] public int ReviveTimes;
		[ProtoMember(28)] public int BreakTimes;
		[ProtoMember(29)] public int ExtraTurns;
		[ProtoMember(30)] public double TotalShield;
		[ProtoMember(31)] public double TotalShieldTaken;
		[ProtoMember(32)] public double TotalShieldDamage;
		[ProtoMember(33)] public AvatarProperty InitialStatus;
		[ProtoMember(34)] public List<BattleRelic> Relics;
		[ProtoMember(35)] public int AssistUid;
		[ProtoMember(36)] public List<AttackDamageProperty> AHGLCCADNCI;
		[ProtoMember(37)] public double EGCEGDBFEKC;
		[ProtoMember(38)] public double NPIFIBAGCHP;
		[ProtoMember(39)] public double NPMFBAEOECI;
		[ProtoMember(40)] public double HALDPDIFHGN;
		[ProtoMember(41)] public List<OCLBEJIFDKL> IGIBJIPBALC;
	}
	
}
