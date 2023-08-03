namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringTransferCsReq
	{
		[ProtoMember(10)] public int PlaneId;
		[ProtoMember(13)] public int FloorId;
		[ProtoMember(3)] public int PropEntityId;
	}
	
}
