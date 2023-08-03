namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterTrialActivityStageCsReq
	{
		[ProtoMember(10)] public int StageId;
	}
	
}
