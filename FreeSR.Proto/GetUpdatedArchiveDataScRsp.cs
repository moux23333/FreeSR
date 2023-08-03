namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetUpdatedArchiveDataScRsp
	{
		[ProtoMember(6)] public ArchiveData ArchiveData;
		[ProtoMember(14)] public int Retcode;
	}
	
}
