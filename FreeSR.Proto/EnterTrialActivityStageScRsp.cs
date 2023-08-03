namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterTrialActivityStageScRsp
	{
		[ProtoMember(14)] public SceneBattleInfo BattleInfo;
		[ProtoMember(10)] public int Retcode;
	}
	
}
