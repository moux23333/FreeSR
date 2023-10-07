namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ItemCost
	{
		[ProtoMember(7)] public PileItem PileItem;
		[ProtoMember(10)] public int EquipmentUniqueId;
		[ProtoMember(5)] public int RelicUniqueId;
	}

}
