namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ClientMail
	{
		[ProtoMember(3)] public string Title;
		[ProtoMember(7)] public int TemplateId;
		[ProtoMember(12)] public OOEJFBNGNKH MailType;
		[ProtoMember(15)] public ItemList Attachment;
		[ProtoMember(14)] public List<string> ParaList;
		[ProtoMember(6)] public bool IsRead;
		[ProtoMember(13)] public int ExpireTime;
		[ProtoMember(5)] public int Time;
		[ProtoMember(10)] public string Content;
		[ProtoMember(2)] public string Sender;
		[ProtoMember(11)] public int Id;
	}

}
