namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LGANCJKENKN
	{
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(8)] public SceneBattleInfo BattleInfo;
		[ProtoMember(10)] public int Id;
	}

}
