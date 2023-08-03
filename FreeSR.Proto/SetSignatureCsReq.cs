namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetSignatureCsReq
	{
		[ProtoMember(4)] public string Signature;
	}
	
}
