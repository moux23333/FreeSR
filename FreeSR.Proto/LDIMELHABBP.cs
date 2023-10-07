namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LDIMELHABBP
	{
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(8)] public int Glinodfncno;
	}

}
