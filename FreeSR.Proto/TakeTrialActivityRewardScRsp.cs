namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeTrialActivityRewardScRsp
	{
		[ProtoMember(6)] public ItemList Reward;
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(7)] public int StageId;
	}
	
}
