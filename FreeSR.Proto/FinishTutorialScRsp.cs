namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishTutorialScRsp
	{
		[ProtoMember(11)] public Tutorial Tutorial;
		[ProtoMember(2)] public int Retcode;
	}
	
}
