namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class JoinLineupCsReq
	{
		[ProtoMember(3)] public bool IsVirtual;
		[ProtoMember(12)] public int BaseAvatarId;
		[ProtoMember(15)] public AvatarType AvatarType;
		[ProtoMember(9)] public int PlaneId;
		[ProtoMember(4)] public int Slot;
		[ProtoMember(2)] public int Index;
		[ProtoMember(13)] public ExtraLineupType ExtraLineupType;
	}
	
}
