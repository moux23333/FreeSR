namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class RaidKickByServerScNotify
	{
		[ProtoMember(10)] public SceneInfo Scene;
		[ProtoMember(13)] public LineupInfo Lineup;
		[ProtoMember(3)] public int WorldLevel;
		[ProtoMember(1)] public OAGENCOPKHH DHPEPIGFAPF;
		[ProtoMember(15)] public int RaidId;
	}
	
}
