namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetArchiveDataScRsp
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(12)] public ArchiveData ArchiveData;
	}
	
}
