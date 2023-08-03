namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetSecretKeyInfoScRsp
	{
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(10)] public List<KLKEEFGJEFP> Type;
		[ProtoMember(13)] public byte[] HGGIOMLDANA;
	}
	
}
