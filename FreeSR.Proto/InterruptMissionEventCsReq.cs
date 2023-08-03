namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class InterruptMissionEventCsReq
	{
		[ProtoMember(13)] public int MissionEventId;
	}
	
}
