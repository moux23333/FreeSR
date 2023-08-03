namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetFirstTalkNpcScRsp
	{
		[ProtoMember(15)] public int Retcode;
		[ProtoMember(13)] public List<NpcMeetStatus> NpcMeetStatusList;
	}
	
}
