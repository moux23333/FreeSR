namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMissionStatusScRsp
	{
		[ProtoMember(6)] public List<int> FinishedMainMissionIdList;
		[ProtoMember(8)] public List<Mission> SubMissionStatusList;
		[ProtoMember(14)] public List<Mission> MissionEventStatusList;
		[ProtoMember(4)] public List<int> UnfinishedMainMissionIdList;
		[ProtoMember(3)] public List<int> DisabledMainMissionIdList;
		[ProtoMember(1)] public int Retcode;
	}
	
}
