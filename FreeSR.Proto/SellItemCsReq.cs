namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SellItemCsReq
	{
		[ProtoMember(14)] public ItemCostData CostData;
	}
	
}
