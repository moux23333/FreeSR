namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetFirstTalkByPerformanceNpcCsReq
	{
		[ProtoMember(8)] public List<int> NLKBFFBDFLG;
	}
	
}
