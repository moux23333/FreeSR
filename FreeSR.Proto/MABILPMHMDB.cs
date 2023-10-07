namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class MABILPMHMDB
	{
		[ProtoMember(1)] public KHMDJAECCFI BlackInfo;
		[ProtoMember(8)] public int Retcode;
	}

}
