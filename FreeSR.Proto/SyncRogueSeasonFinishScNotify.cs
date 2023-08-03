namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncRogueSeasonFinishScNotify
	{
		[ProtoMember(10)] public SceneInfo Scene;
		[ProtoMember(2)] public ILAMCHCKLGE FMEAAIOCKNB;
		[ProtoMember(12)] public RogueFinishInfo FinishInfo;
		[ProtoMember(4)] public bool AFIPMLNNKON;
		[ProtoMember(6)] public LineupInfo Lineup;
	}
	
}
