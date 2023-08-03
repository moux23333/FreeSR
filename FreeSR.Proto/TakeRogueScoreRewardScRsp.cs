namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeRogueScoreRewardScRsp
	{
		[ProtoMember(11)] public int ECJCMODPEFI;
		[ProtoMember(12)] public int Retcode;
		[ProtoMember(7)] public ItemList Reward;
		[ProtoMember(1)] public ILAMCHCKLGE FMEAAIOCKNB;
	}
	
}
