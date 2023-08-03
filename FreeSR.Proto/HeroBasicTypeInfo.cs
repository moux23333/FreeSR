namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HeroBasicTypeInfo
	{
		[ProtoMember(7)] public int Rank;
		[ProtoMember(4)] public HeroBasicType BasicType;
		[ProtoMember(13)] public List<AvatarSkillTree> SkillTreeList;
	}
	
}
