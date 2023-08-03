namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringRecoverSingleAvatarCsReq
	{
		[ProtoMember(7)] public int Id;
		[ProtoMember(13)] public int PlaneId;
		[ProtoMember(8)] public int FloorId;
		[ProtoMember(3)] public int PropEntityId;
		[ProtoMember(15)] public AvatarType AvatarType;
		[ProtoMember(5)] public bool RecoverFull;
	}
	
}
