namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneCastSkillScRsp
	{
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(8)] public int CGBLGAIDCAB;
		[ProtoMember(5)] public SceneBattleInfo BattleInfo;
	}
	
}
