namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetSignatureScRsp
	{
		[ProtoMember(10)] public string Signature;
		[ProtoMember(1)] public int Retcode;
	}
	
}
