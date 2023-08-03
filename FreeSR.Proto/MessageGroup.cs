namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MessageGroup
	{
		[ProtoMember(4)] public List<MessageSection> MessageSectionList;
		[ProtoMember(15)] public MessageGroupStatus Status;
		[ProtoMember(3)] public long RefreshTime;
		[ProtoMember(13)] public int MessageSectionId;
		[ProtoMember(5)] public int Id;
	}
	
}
