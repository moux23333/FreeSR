namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncLineupNotify
	{
		[ProtoMember(10)] public List<SyncLineupReason> ReasonList;
		[ProtoMember(7)] public LineupInfo Lineup;
	}
	
}
