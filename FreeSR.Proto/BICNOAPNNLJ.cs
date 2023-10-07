namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BICNOAPNNLJ
	{
		[ProtoMember(11)] public List<ItemCost> ItemList;
	}

}
