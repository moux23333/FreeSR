namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPlatformPlayerInfoCsReq
	{
		[ProtoMember(10)] public PlatformType Platform;
		[ProtoMember(6)] public List<string> GNMNEBKHOEL;
	}
	
}
