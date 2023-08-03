namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ClientMail
	{
		[ProtoMember(12)] public bool IsRead;
		[ProtoMember(9)] public string Title;
		[ProtoMember(13)] public long Time;
		[ProtoMember(4)] public string Content;
		[ProtoMember(8)] public long ExpireTime;
		[ProtoMember(11)] public ItemList Attachment;
		[ProtoMember(7)] public string Sender;
		[ProtoMember(15)] public int TemplateId;
		[ProtoMember(10)] public List<string> ParaList;
		[ProtoMember(14)] public int Id;
	}
	
}
