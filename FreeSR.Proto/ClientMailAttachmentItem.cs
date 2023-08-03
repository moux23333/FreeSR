namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ClientMailAttachmentItem
	{
		[ProtoMember(4)] public int ItemId;
		[ProtoMember(15)] public int MailId;
	}
	
}
