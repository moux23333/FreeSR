namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetFirstTalkByPerformanceNpcScRsp
	{
		[ProtoMember(2)] public int Retcode;
		[ProtoMember(13)] public List<OCLEPLBNNPA> NpcMeetStatusList;
	}

}
