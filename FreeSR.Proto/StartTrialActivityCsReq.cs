namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartTrialActivityCsReq
	{
		[ProtoMember(8)] public int StageId;
	}
	
}
