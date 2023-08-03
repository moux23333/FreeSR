namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Avatar
	{
		[ProtoMember(1)] public long FirstMetTimeStamp;
		[ProtoMember(5)] public List<int> ABGANGFFNDF;
		[ProtoMember(4)] public List<EquipRelic> EquipRelicList;
		[ProtoMember(7)] public int Promotion;
		[ProtoMember(11)] public int BaseAvatarId;
		[ProtoMember(9)] public int Rank;
		[ProtoMember(15)] public int Exp;
		[ProtoMember(6)] public List<AvatarSkillTree> SkilltreeList;
		[ProtoMember(12)] public int EquipmentUniqueId;
		[ProtoMember(10)] public int Level;
	}
	
}
