namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ActivateFarmElementCsReq
	{
		[ProtoMember(1)] public int WorldLevel;
		[ProtoMember(4)] public int EntityId;
	}
	
}
