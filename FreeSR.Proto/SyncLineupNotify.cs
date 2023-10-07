namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SyncLineupNotify
	{
		[ProtoMember(3)] public LineupInfo Lineup;
		[ProtoMember(6)] public List<KMCINAPPNGP> ReasonList;
	}

}
