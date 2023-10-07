namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HeroBasicTypeInfo
	{
		[ProtoMember(10)] public HeroBasicType BasicType;
		[ProtoMember(15)] public List<AvatarSkillTree> SkillTreeList;
		[ProtoMember(14)] public int Rank;
	}

}
