namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DJBJONGPBNP
	{
		[ProtoMember(1)] public List<PunkLordBattleRecord> BattleRecordList;
	}
	
}
