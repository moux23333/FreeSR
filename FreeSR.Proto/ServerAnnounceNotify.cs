namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ServerAnnounceNotify
	{
		[ProtoMember(1)] public List<AnnounceData> AnnounceDataList;
	}
	
}
