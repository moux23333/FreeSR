namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MLFJLICPKCK
	{
		[ProtoMember(9)] public bool IsVirtual;
		[ProtoMember(11)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(3)] public int Index;
		[ProtoMember(6)] public int BaseAvatarId;
		[ProtoMember(1)] public int PlaneId;
		[ProtoMember(13)] public AvatarType AvatarType;
	}

}
