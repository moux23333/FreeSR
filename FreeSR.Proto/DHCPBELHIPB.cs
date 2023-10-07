namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DHCPBELHIPB
	{
		[ProtoMember(4)] public int FloorId;
		[ProtoMember(11)] public int PropEntityId;
		[ProtoMember(6)] public int PlaneId;
	}

}
