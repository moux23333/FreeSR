namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PlayerHeartBeatCsReq
	{
		[ProtoMember(3)] public long ClientTimeMs;
		[ProtoMember(6)] public int Dclhjdkbbak;
		[ProtoMember(10)] public ClientUploadData UploadData;
	}

}
