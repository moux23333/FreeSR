namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMissionStatusCsReq
	{
		[ProtoMember(1)] public List<int> MainMissionIdList;
		[ProtoMember(9)] public List<int> MissionEventIdList;
		[ProtoMember(15)] public List<int> SubMissionIdList;
	}
	
}
