namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PromoteAvatarCsReq
	{
		[ProtoMember(6)] public List<ItemCost> ItemCost;
		[ProtoMember(5)] public int BaseAvatarId;
	}
	
}
