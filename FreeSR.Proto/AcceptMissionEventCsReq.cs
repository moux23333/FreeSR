namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AcceptMissionEventCsReq
	{
		[ProtoMember(13)] public int MissionEventId;
	}
	
}
