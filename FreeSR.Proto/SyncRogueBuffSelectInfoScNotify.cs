namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncRogueBuffSelectInfoScNotify
	{
		[ProtoMember(5)] public RogueBuffSelectInfo BuffSelectInfo;
	}
	
}
