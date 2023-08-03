namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ComposeSelectedRelicCsReq
	{
		[ProtoMember(14)] public int MainAffixId;
		[ProtoMember(10)] public int ComposeId;
		[ProtoMember(5)] public int Count;
		[ProtoMember(7)] public int PNIHPOFJIIF;
		[ProtoMember(8)] public ItemCostData BEDCMPKEFDK;
	}
	
}
