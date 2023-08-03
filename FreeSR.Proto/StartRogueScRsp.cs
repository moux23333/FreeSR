namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartRogueScRsp
	{
		[ProtoMember(8)] public SceneInfo Scene;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(11)] public RogueInfo RogueInfo;
		[ProtoMember(1)] public LineupInfo Lineup;
	}
	
}
