namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterRogueScRsp
	{
		[ProtoMember(14)] public SceneInfo Scene;
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(11)] public LineupInfo Lineup;
		[ProtoMember(12)] public RogueInfo RogueInfo;
	}
	
}
