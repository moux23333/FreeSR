namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ApplyFriendCsReq
	{
		[ProtoMember(12)] public int Uid;
		[ProtoMember(8)] public CKBOGLGFCEJ Source;
	}
	
}
