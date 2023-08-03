namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NpcStatus
	{
		[ProtoMember(6)] public bool IsFinish;
		[ProtoMember(8)] public int NpcId;
	}
	
}
