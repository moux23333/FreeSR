namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterFantasticStoryActivityStageScRsp
	{
		[ProtoMember(1)] public int BattleId;
		[ProtoMember(7)] public int KNBOIOPGGFN;
		[ProtoMember(10)] public SceneBattleInfo BattleInfo;
		[ProtoMember(8)] public int Retcode;
	}
	
}
