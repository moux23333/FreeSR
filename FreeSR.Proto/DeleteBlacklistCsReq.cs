namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DeleteBlacklistCsReq
	{
		[ProtoMember(2)] public int Uid;
	}
	
}
