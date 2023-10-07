namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Avatar
	{
		[ProtoMember(13)] public List<int> Fbelhlidemb;
		[ProtoMember(9)] public long FirstMetTimestamp;
		[ProtoMember(7)] public int Rank;
		[ProtoMember(14)] public List<EquipRelic> EquipRelicList;
		[ProtoMember(8)] public int Promotion;
		[ProtoMember(11)] public int BaseAvatarId;
		[ProtoMember(6)] public int Level;
		[ProtoMember(3)] public List<AvatarSkillTree> SkilltreeList;
		[ProtoMember(12)] public int EquipmentUniqueId;
		[ProtoMember(2)] public int Exp;
	}

}
