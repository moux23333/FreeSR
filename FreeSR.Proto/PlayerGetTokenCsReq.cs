namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerGetTokenCsReq
	{
		[ProtoMember(10)] public string FBLCMKJJDNF;
		[ProtoMember(14)] public int Uid;
		[ProtoMember(13)] public string Token;
		[ProtoMember(1)] public string AccountUid;
		[ProtoMember(8)] public int CPIDNMPJLIN;
		[ProtoMember(4)] public int EINCAOLOEJC;
		[ProtoMember(6)] public int Platform;
		[ProtoMember(2)] public int AGBKHCDOHIB;
	}
	
}
