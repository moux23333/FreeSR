namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DisplayAvatarDetailInfo
	{
		[ProtoMember(8)] public int AvatarId;
		[ProtoMember(9)] public int Promotion;
		[ProtoMember(3)] public PMNHNDIHGNJ Equipment;
		[ProtoMember(14)] public List<AvatarSkillTree> SkilltreeList;
		[ProtoMember(11)] public int Pos;
		[ProtoMember(4)] public int Exp;
		[ProtoMember(15)] public List<NJOCOFLIPDP> RelicList;
		[ProtoMember(1)] public int Level;
		[ProtoMember(2)] public int Rank;
	}

}
