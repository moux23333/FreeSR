namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ReEnterLastElementStageScRsp
	{
		[ProtoMember(4)] public int StageId;
		[ProtoMember(3)] public SceneBattleInfo BattleInfo;
		[ProtoMember(11)] public int Retcode;
	}
	
}
