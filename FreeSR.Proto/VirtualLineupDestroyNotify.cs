namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class VirtualLineupDestroyNotify
	{
		[ProtoMember(9)] public int PlaneId;
	}
	
}
