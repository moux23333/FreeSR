namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleAvatar
	{
		[ProtoMember(1)] public AvatarType AvatarType;
		[ProtoMember(2)] public int Id;
		[ProtoMember(3)] public int Level;
		[ProtoMember(4)] public int Rank;
		[ProtoMember(5)] public int Index;
		[ProtoMember(6)] public List<AvatarSkillTree> SkilltreeList;
		[ProtoMember(7)] public List<BattleEquipment> EquipmentList;
		[ProtoMember(8)] public int Sp;
		[ProtoMember(10)] public int Promotion;
		[ProtoMember(11)] public List<BattleRelic> RelicList;
		[ProtoMember(12)] public int WorldLevel;
		[ProtoMember(13)] public int AssistUid;
		[ProtoMember(15)] public GDNNODDEOGK Ncofmmffhbi;
		[ProtoMember(16)] public HealthBarInfo CurHealth;
	}

}
