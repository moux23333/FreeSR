namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class QuitLineupCsReq
	{
		[ProtoMember(10)] public int Index;
		[ProtoMember(1)] public int PlaneId;
		[ProtoMember(2)] public bool IsVirtual;
		[ProtoMember(12)] public int BaseAvatarId;
		[ProtoMember(5)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(3)] public AvatarType AvatarType;
	}
	
}
