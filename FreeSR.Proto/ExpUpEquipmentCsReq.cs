namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExpUpEquipmentCsReq
	{
		[ProtoMember(15)] public int EquipmentUniqueId;
		[ProtoMember(5)] public ItemCostData CostData;
	}
	
}
