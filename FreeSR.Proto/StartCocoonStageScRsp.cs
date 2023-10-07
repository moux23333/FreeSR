namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class StartCocoonStageScRsp
	{
		[ProtoMember(2)] public int Wave;
		[ProtoMember(15)] public int CocoonId;
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(11)] public SceneBattleInfo BattleInfo;
		[ProtoMember(14)] public int PropEntityId;
	}

}
