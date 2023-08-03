namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PVEBattleResultCsReq
	{
		[ProtoMember(8)] public Dictionary<string, int> DEEIOAINCFH;
		[ProtoMember(12)] public byte[] TurnSnapshotHash;
		[ProtoMember(10)] public BattleEndStatus EndStatus;
		[ProtoMember(5)] public bool KIOKFJNPIBD;
		[ProtoMember(1)] public int ClientVersion;
		[ProtoMember(2)] public List<BattleOp> OpList;
		[ProtoMember(7)] public int StageId;
		[ProtoMember(15)] public BattleStatistics NABHPKACFAN;
		[ProtoMember(4)] public int BattleId;
		[ProtoMember(11)] public int ACAKAMKDKNH;
		[ProtoMember(13)] public int CostTime;
		[ProtoMember(3)] public bool IsAiConsiderUltraSkill;
		[ProtoMember(14)] public int ResVersion;
		[ProtoMember(9)] public string BJCFCNGMOPB;
	}
	
}
