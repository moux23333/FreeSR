namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EnterFightActivityStageScRsp
	{
		[ProtoMember(7)] public int IFIGMNFCELG;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(3)] public SceneBattleInfo BattleInfo;
		[ProtoMember(1)] public int GroupId;
	}
	
}
