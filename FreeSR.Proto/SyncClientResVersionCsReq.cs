namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncClientResVersionCsReq
	{
		[ProtoMember(12)] public int ResVersion;
	}
	
}
