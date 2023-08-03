namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ItemList
	{
		[ProtoMember(9)] public List<Item> List;
	}
	
}
