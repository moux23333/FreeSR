namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetMissionDataScRsp
	{
		[ProtoMember(12)] public List<Mission> MissionList;
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(7)] public List<GKLKGMNMHPG> MIEEPAJJAEK;
	}
	
}
