namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FinishTutorialScRsp
	{
		[ProtoMember(12)] public Tutorial Tutorial;
		[ProtoMember(6)] public int Retcode;
	}

}
