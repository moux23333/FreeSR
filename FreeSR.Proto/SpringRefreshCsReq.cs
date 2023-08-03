namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringRefreshCsReq
	{
		[ProtoMember(11)] public int PropEntityId;
		[ProtoMember(4)] public int FloorId;
		[ProtoMember(10)] public int PlaneId;
	}
	
}
