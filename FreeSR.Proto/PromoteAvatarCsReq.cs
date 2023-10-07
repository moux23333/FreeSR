namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PromoteAvatarCsReq
	{
		[ProtoMember(15)] public List<ItemCost> ItemList;
		[ProtoMember(5)] public int BaseAvatarId;
	}

}
