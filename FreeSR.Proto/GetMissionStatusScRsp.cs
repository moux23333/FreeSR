namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMissionStatusScRsp
	{
	    [ProtoMember(11)] public List<int> UnfinishedMainMissionIdList;
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(4)] public List<Mission> MissionEventStatusList;
		[ProtoMember(9)] public List<int> DisabledMainMissionIdList;
		[ProtoMember(13)] public List<Mission> SubMissionStatusList;
		[ProtoMember(10)] public List<int> FinishedMainMissionIdList;


	}
	
}
