namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LeaveRogueScRsp
	{
		[ProtoMember(1)] public SceneInfo Scene;
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(12)] public RogueInfo RogueInfo;
		[ProtoMember(9)] public LineupInfo Lineup;
	}
	
}
