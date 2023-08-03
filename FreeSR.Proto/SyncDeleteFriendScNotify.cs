namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncDeleteFriendScNotify
	{
		[ProtoMember(4)] public int Uid;
	}
	
}
