namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DeleteFriendCsReq
	{
		[ProtoMember(14)] public int Uid;
	}
	
}
