namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UnlockTutorialScRsp
	{
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(9)] public Tutorial Tutorial;
	}

}
