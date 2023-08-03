namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetLevelRewardCsReq
	{
		[ProtoMember(10)] public int ShopId;
		[ProtoMember(2)] public int Level;
	}
	
}
