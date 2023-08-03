namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PromoteEquipmentCsReq
	{
		[ProtoMember(10)] public int EquipmentUniqueId;
		[ProtoMember(3)] public ItemCostData CostData;
	}
	
}
