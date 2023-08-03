namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakePromotionRewardScRsp
	{
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(14)] public ItemList PCEHPCLPNDO;
	}
	
}
