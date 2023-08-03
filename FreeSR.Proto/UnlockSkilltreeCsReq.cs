namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UnlockSkilltreeCsReq
	{
		[ProtoMember(14)] public int PointId;
		[ProtoMember(13)] public int Level;
		[ProtoMember(7)] public List<ItemCost> ItemCost;
	}
	
}
