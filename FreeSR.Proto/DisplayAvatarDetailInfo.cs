namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DisplayAvatarDetailInfo
	{
		[ProtoMember(15)] public int Pos;
		[ProtoMember(10)] public List<HPDIBDEACLC> RelicList;
		[ProtoMember(3)] public int Rank;
		[ProtoMember(2)] public int Exp;
		[ProtoMember(12)] public NGCDGFOAIHH Equipment;
		[ProtoMember(14)] public int Promotion;
		[ProtoMember(9)] public List<AvatarSkillTree> SkilltreeList;
		[ProtoMember(1)] public int Level;
		[ProtoMember(5)] public int AvatarId;
	}
	
}
