namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NOBPNCCGLNB
	{
		[ProtoMember(8)] public ArchiveData ArchiveData;
		[ProtoMember(9)] public int Retcode;
	}

}
