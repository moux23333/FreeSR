namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class OKOHAOLFPFK
	{
		[ProtoMember(4)] public List<int> BaseAvatarIdList;
		[ProtoMember(13)] public int PropEntityId;
	}

}
