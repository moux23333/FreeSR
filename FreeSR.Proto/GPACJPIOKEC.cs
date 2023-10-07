namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GPACJPIOKEC
	{
		[ProtoMember(9)] public int FloorId;
		[ProtoMember(5)] public int PropEntityId;
		[ProtoMember(8)] public int PlaneId;
	}

}
