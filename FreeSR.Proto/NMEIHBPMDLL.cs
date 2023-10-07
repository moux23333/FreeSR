namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NMEIHBPMDLL
	{
		[ProtoMember(6)] public int Retcode;
		[ProtoMember(2)] public List<int> Ncnhpbjcbfp;
	}

}
