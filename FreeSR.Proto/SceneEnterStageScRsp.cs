namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneEnterStageScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(8)] public SceneBattleInfo BattleInfo;
	}
	
}
