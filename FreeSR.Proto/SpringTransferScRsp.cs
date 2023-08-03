namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringTransferScRsp
	{
		[ProtoMember(1)] public int Retcode;
	}
	
}
