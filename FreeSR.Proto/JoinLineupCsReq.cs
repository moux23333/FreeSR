namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class JoinLineupCsReq
	{
		[ProtoMember(9)] public bool IsVirtual;
		[ProtoMember(6)] public int BaseAvatarId;
		[ProtoMember(3)] public int Index;
		[ProtoMember(11)] public int PlaneId;
		[ProtoMember(7)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(13)] public int Slot;
		[ProtoMember(2)] public AvatarType AvatarType;
	}

}
