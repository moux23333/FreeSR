namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetChatFriendHistoryScRsp
	{
		[ProtoMember(11)] public int Retcode;
		[ProtoMember(2)] public List<JAKGDJEHMMI> FriendHistoryList;
	}
	
}
