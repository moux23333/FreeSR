namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AvatarSkillTree
	{
		[ProtoMember(1)] public int PointId;
		[ProtoMember(2)] public int Level;
	}

}
