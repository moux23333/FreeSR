namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NPIHCCILEFF
	{
		[ProtoMember(11)] public int PointId;
		[ProtoMember(1)] public int Level;
		[ProtoMember(3)] public List<ItemCost> ItemList;
	}

}
