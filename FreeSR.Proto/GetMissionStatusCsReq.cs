namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMissionStatusCsReq
	{
		[ProtoMember(7)] public List<int> MainMissionIdList;
		[ProtoMember(11)] public List<int> MissionEventIdList;
		[ProtoMember(15)] public List<int> SubMissionIdList;
	}
	
}
