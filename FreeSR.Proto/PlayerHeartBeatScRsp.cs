namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerHeartBeatScRsp
	{
		[ProtoMember(3)] public ClientDownloadData DownloadData;
		[ProtoMember(4)] public long ServerTimeMs;
		[ProtoMember(10)] public long ClientTimeMs;
		[ProtoMember(15)] public int Retcode;
	}

}
