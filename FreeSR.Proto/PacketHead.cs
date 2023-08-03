namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PacketHead
	{
		[ProtoMember(1)] public int PacketId;
		[ProtoMember(2)] public int SignType;
		[ProtoMember(3)] public int Sign;
		[ProtoMember(4)] public int UserId;
		[ProtoMember(5)] public int SrcAddr;
		[ProtoMember(6)] public int DstAddr;
		[ProtoMember(7)] public int DispatchType;
		[ProtoMember(8)] public int ServerType;
		[ProtoMember(9)] public int DispatchKey;
		[ProtoMember(10)] public int UserSessionId;
		[ProtoMember(11)] public int Id;
		[ProtoMember(12)] public int CoroutineId;
		[ProtoMember(13)] public int HopCnt;
	}
	
}
