namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class JIPIMNOMODB
	{
		[ProtoMember(8)] public SceneBattleInfo BattleInfo;
		[ProtoMember(5)] public int Retcode;
	}

}
