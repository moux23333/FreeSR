namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetMissionEventProgressCsReq
	{
		[ProtoMember(11)] public int MissionEventId;
		[ProtoMember(2)] public int Progress;
	}
	
}
