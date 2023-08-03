namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterActivityBattleStageScRsp
	{
		[ProtoMember(6)] public int StageId;
		[ProtoMember(4)] public SceneBattleInfo BattleInfo;
		[ProtoMember(13)] public int IFIGMNFCELG;
		[ProtoMember(12)] public int MFOPLCBNNHL;
		[ProtoMember(5)] public int Retcode;
	}
	
}
