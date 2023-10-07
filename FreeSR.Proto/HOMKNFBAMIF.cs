namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HOMKNFBAMIF
	{
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(3)] public string Signature;
	}

}
