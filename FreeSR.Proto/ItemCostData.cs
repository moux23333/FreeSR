namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ItemCostData
	{
		[ProtoMember(3)] public List<ItemCost> ItemCost;
	}
	
}
