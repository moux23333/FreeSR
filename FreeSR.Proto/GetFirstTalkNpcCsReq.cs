namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetFirstTalkNpcCsReq
	{
		[ProtoMember(13)] public List<int> SeriesIdList;
	}
	
}
