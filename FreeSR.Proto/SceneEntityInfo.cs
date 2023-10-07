namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEntityInfo
	{
		[ProtoMember(11)] public SceneActorInfo Actor;
		[ProtoMember(10)] public SceneNpcMonsterInfo NpcMonster;
		[ProtoMember(1)] public SceneNpcInfo Npc;
		[ProtoMember(5)] public ScenePropInfo Prop;
		[ProtoMember(12)] public SceneSummonUnitInfo SummonUnit;
		[ProtoMember(4)] public int EntityId;
		[ProtoMember(3)] public int InstId;
		[ProtoMember(9)] public int GroupId;
		[ProtoMember(2)] public MotionInfo Motion;
	}

}
