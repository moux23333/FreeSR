namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AddBlacklistCsReq
	{
		[ProtoMember(9)] public int Uid;
	}
	
}
