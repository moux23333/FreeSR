namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ActivateFarmElementScRsp
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(3)] public int WorldLevel;
		[ProtoMember(2)] public int EntityId;
	}
	
}
