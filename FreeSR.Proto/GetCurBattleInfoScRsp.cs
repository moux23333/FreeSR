namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetCurBattleInfoScRsp
	{
		[ProtoMember(7)] public BattleEndStatus LastEndStatus;
		[ProtoMember(11)] public SceneBattleInfo BattleInfo;
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(10)] public int StageId;
	}

}
