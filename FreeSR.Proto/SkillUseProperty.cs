namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SkillUseProperty
	{
		[ProtoMember(1)] public int SkillId;
		[ProtoMember(2)] public string SkillType;
		[ProtoMember(3)] public int SkillLevel;
		[ProtoMember(4)] public int SkillUseCount;
	}

}
