namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DBGMKLOAPFN
	{
		[ProtoMember(13)] public int PlaneId;
		[ProtoMember(8)] public int PropEntityId;
		[ProtoMember(4)] public int FloorId;
	}

}
