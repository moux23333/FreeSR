namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncRogueMapRoomScNotify
	{
		[ProtoMember(8)] public RogueRoom RoomInfo;
		[ProtoMember(13)] public int HICDOKIDPDA;
	}
	
}
