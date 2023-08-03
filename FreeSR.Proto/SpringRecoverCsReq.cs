namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringRecoverCsReq
	{
		[ProtoMember(12)] public int FloorId;
		[ProtoMember(9)] public int PlaneId;
		[ProtoMember(6)] public int PropEntityId;
	}
	
}
