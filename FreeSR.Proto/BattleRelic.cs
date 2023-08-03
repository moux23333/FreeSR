namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleRelic
	{
		[ProtoMember(1)] public int Id;
		[ProtoMember(2)] public int Level;
		[ProtoMember(3)] public int MainAffixId;
		[ProtoMember(4)] public List<RelicAffix> SubAffixList;
		[ProtoMember(5)] public int UniqueId;
		[ProtoMember(6)] public int LHHJHGAONBM;
		[ProtoMember(7)] public int Type;
		[ProtoMember(8)] public int CMIFJJMHNNO;
	}
	
}
