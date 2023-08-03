namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetCurBattleInfoScRsp
	{
		[ProtoMember(14)] public BattleEndStatus LastEndStatus;
		[ProtoMember(5)] public SceneBattleInfo BattleInfo;
		[ProtoMember(15)] public int StageId;
		[ProtoMember(9)] public int Retcode;
	}
	
}
