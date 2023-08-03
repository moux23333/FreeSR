namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartTrialActivityScRsp
	{
		[ProtoMember(15)] public int StageId;
		[ProtoMember(1)] public int Retcode;
	}
	
}
