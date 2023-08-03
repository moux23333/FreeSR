namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AvatarExpUpCsReq
	{
		[ProtoMember(8)] public int BaseAvatarId;
		[ProtoMember(6)] public ItemCostData ItemCost;
	}
	
}
