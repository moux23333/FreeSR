namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MessageItem
	{
		[ProtoMember(5)] public int TextId;
		[ProtoMember(11)] public int ItemId;
	}
	
}
