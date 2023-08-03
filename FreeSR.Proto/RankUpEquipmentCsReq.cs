namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RankUpEquipmentCsReq
	{
		[ProtoMember(15)] public int EquipmentUniqueId;
		[ProtoMember(11)] public ItemCostData CostData;
	}
	
}
