namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LockRelicCsReq
	{
		[ProtoMember(12)] public int RelicUniqueId;
		[ProtoMember(11)] public bool IsLock;
	}
	
}
