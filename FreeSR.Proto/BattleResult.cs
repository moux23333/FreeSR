namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleResult
	{
		[ProtoMember(1)] public BattleCheckResultType Retcode;
		[ProtoMember(2)] public BattleEndStatus EndStatus;
		[ProtoMember(3)] public BattleStatistics Stt;
		[ProtoMember(4)] public byte[] GameCoreLogEncode;
		[ProtoMember(5)] public Dictionary<string, int> Tags;
		[ProtoMember(6)] public int MismatchTurnCount;
		[ProtoMember(7)] public int Pmmahjjhnhm;
	}

}
