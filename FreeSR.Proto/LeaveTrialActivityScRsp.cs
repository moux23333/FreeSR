namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LeaveTrialActivityScRsp
	{
		[ProtoMember(1)] public int StageId;
		[ProtoMember(15)] public int Retcode;
	}
	
}
