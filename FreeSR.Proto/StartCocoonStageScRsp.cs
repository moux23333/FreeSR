namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartCocoonStageScRsp
	{
		[ProtoMember(9)] public int CocoonId;
		[ProtoMember(10)] public int Wave;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(14)] public int PropEntityId;
		[ProtoMember(8)] public SceneBattleInfo BattleInfo;
	}
	
}
