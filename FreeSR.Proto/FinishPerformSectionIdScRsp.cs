namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishPerformSectionIdScRsp
	{
		[ProtoMember(8)] public int SectionId;
		[ProtoMember(11)] public int Retcode;
		[ProtoMember(6)] public List<MessageItem> ItemCost;
		[ProtoMember(12)] public ItemList Reward;
	}
	
}
