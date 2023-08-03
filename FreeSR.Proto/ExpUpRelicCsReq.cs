namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExpUpRelicCsReq
	{
		[ProtoMember(13)] public ItemCostData CostData;
		[ProtoMember(12)] public int RelicUniqueId;
	}
	
}
