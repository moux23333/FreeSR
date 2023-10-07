namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class NJOCOFLIPDP
	{
		[ProtoMember(7)] public int Level;
		[ProtoMember(14)] public List<RelicAffix> SubAffixList;
		[ProtoMember(15)] public int Exp;
		[ProtoMember(4)] public int MainAffixId;
		[ProtoMember(9)] public int Gdpgidgcgke;
		[ProtoMember(6)] public int Tid;
	}

}
