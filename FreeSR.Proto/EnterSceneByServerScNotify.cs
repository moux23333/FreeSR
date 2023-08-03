namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterSceneByServerScNotify
	{
		[ProtoMember(7)] public SceneInfo Scene;
		[ProtoMember(10)] public JCBLONKKIIM DHPEPIGFAPF;
		[ProtoMember(5)] public LineupInfo Lineup;
	}
	
}
