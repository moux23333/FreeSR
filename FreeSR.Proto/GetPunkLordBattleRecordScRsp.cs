namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPunkLordBattleRecordScRsp
	{
		[ProtoMember(7)] public GJIDDPIJAEL BKIIBBNKBHN;
		[ProtoMember(4)] public List<PunkLordBattleReplay> EDNMENMNFKH;
		[ProtoMember(8)] public List<PunkLordBattleRecord> BattleRecordList;
		[ProtoMember(15)] public int Retcode;
	}
	
}
