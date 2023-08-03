namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeMailAttachmentCsReq
	{
		[ProtoMember(6)] public int OptionalRewardId;
		[ProtoMember(12)] public List<int> MailIdList;
	}
	
}
