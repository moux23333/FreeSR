namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetFirstTalkByPerformanceNpcScRsp
	{
		[ProtoMember(5)] public int Retcode;
		[ProtoMember(7)] public List<PLGKGCOKJOH> NpcMeetStatusList;
	}
	
}
