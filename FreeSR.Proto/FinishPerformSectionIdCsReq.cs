namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishPerformSectionIdCsReq
	{
		[ProtoMember(1)] public List<MessageItem> ItemCost;
		[ProtoMember(15)] public int SectionId;
	}
	
}
