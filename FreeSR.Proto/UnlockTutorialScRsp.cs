namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class UnlockTutorialScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(15)] public Tutorial Tutorial;
	}
	
}
