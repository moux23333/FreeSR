namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeTrialActivityRewardCsReq
	{
		[ProtoMember(6)] public int StageId;
	}
	
}
