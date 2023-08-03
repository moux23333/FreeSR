namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ComposeItemCsReq
	{
		[ProtoMember(10)] public ItemCostData BEDCMPKEFDK;
		[ProtoMember(4)] public int ComposeId;
		[ProtoMember(2)] public int Count;
	}
	
}
