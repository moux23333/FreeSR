namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MessageSection
	{
		[ProtoMember(8)] public int Id;
		[ProtoMember(12)] public int MessageItemId;
		[ProtoMember(4)] public List<MessageItem> ItemList;
		[ProtoMember(10)] public List<int> ENNACKPMCLL;
		[ProtoMember(15)] public MessageSectionStatus Status;
	}
	
}
