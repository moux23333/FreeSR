namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LeaveTrialActivityCsReq
	{
		[ProtoMember(9)] public int StageId;
	}
	
}
