namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HandleFriendCsReq
	{
		[ProtoMember(9)] public int Uid;
		[ProtoMember(15)] public bool KOFFCJPACPJ;
	}
	
}
