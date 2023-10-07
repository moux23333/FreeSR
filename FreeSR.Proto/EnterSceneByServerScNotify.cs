namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterSceneByServerScNotify
	{
		[ProtoMember(5)] public EnterSceneReason Reason;
		[ProtoMember(14)] public LineupInfo Lineup;
		[ProtoMember(15)] public SceneInfo Scene;
	}

}
