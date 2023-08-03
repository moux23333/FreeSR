namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMissionEventDataScRsp
	{
		[ProtoMember(10)] public int ChallengeEventId;
		[ProtoMember(5)] public int Retcode;
		[ProtoMember(7)] public List<Mission> MissionEventList;
	}
	
}
