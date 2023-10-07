namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeMailAttachmentScRsp
	{
		[ProtoMember(8)] public List<HGDPJHJGHOI> FailMailList;
		[ProtoMember(11)] public ItemList Attachment;
		[ProtoMember(12)] public int Retcode;
		[ProtoMember(6)] public List<int> SuccMailIdList;
	}

}
