namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartPunkLordRaidCsReq
	{
		[ProtoMember(14)] public int Uid;
		[ProtoMember(6)] public int MonsterId;
		[ProtoMember(3)] public bool CMOKGEKCMNG;
	}
	
}
