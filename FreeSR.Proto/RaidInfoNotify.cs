namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RaidInfoNotify
	{
		[ProtoMember(5)] public ItemList ItemCost;
		[ProtoMember(9)] public List<GEAPFJEPNKD> IINHMHPKKML;
		[ProtoMember(4)] public int RaidId;
		[ProtoMember(15)] public long EMADCJLIDHN;
		[ProtoMember(1)] public int WorldLevel;
		[ProtoMember(12)] public RaidStatus Status;
	}
	
}
