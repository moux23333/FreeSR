namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ItemCost
	{
		[ProtoMember(7)] public PileItem PileItem;
		[ProtoMember(1)] public int EquipmentUniqueId;
		[ProtoMember(11)] public int RelicUniqueId;
	}
	
}
