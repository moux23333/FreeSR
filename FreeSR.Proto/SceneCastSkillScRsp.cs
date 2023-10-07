namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneCastSkillScRsp
	{
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(6)] public int Mpeofcafinh;
		[ProtoMember(4)] public SceneBattleInfo BattleInfo;
	}

}
