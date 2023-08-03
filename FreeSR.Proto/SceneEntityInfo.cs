namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityInfo
	{
		[ProtoMember(11)] public SceneActorInfo Actor;
		[ProtoMember(6)] public SceneNpcMonsterInfo NpcMonster;
		[ProtoMember(15)] public SceneNpcInfo Npc;
		[ProtoMember(7)] public ScenePropInfo Prop;
		[ProtoMember(5)] public MotionInfo Motion;
		[ProtoMember(9)] public int EntityId;
		[ProtoMember(4)] public int InstId;
		[ProtoMember(10)] public int GroupId;
	}
	
}
