namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeExpeditionRewardScRsp
	{
		[ProtoMember(4)] public ItemList PKOECPBCIAP;
		[ProtoMember(9)] public ItemList Reward;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(12)] public int ExpeditionId;
	}
	
}
