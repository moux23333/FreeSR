namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FightTreasureDungeonMonsterScRsp
	{
		[ProtoMember(4)] public SceneBattleInfo BattleInfo;
		[ProtoMember(5)] public int Retcode;
	}
	
}
