namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HOPLOGEDGPK
	{
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(10)] public SceneBattleInfo BattleInfo;
		[ProtoMember(2)] public int StageId;
	}

}
