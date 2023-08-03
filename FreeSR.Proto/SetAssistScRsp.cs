namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetAssistScRsp
	{
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(6)] public int Uid;
	}
	
}
