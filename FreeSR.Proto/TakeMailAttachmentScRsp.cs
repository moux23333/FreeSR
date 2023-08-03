namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeMailAttachmentScRsp
	{
		[ProtoMember(1)] public List<int> SuccMailIdList;
		[ProtoMember(5)] public ItemList Attachment;
		[ProtoMember(12)] public List<ClientMailAttachmentItem> FailMailList;
		[ProtoMember(7)] public int Retcode;
	}
	
}
