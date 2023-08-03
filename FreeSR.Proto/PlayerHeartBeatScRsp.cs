namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerHeartBeatScRsp
	{
		[ProtoMember(7)] public long CurrentTime;
		[ProtoMember(10)] public ClientDownloadData DownloadData;
		[ProtoMember(5)] public long ServerTime;
		[ProtoMember(9)] public int Retcode;
	}
	
}
