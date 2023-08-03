namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ClientDownloadDataScNotify
	{
		[ProtoMember(15)] public ClientDownloadData DownloadData;
	}
	
}
