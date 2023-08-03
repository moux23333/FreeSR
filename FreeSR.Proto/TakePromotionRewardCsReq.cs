namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakePromotionRewardCsReq
	{
		[ProtoMember(14)] public int BaseAvatarId;
		[ProtoMember(10)] public int Promotion;
	}
	
}
