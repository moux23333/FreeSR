namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetArchiveDataScRsp
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(5)] public ArchiveData ArchiveData;
	}

}
