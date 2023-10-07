namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HODICHADMMC
	{
		[ProtoMember(11)] public int Level;
		[ProtoMember(3)] public List<RelicAffix> SubAffixList;
		[ProtoMember(6)] public int MainAffixId;
		[ProtoMember(7)] public int Exp;
		[ProtoMember(2)] public int Tid;
	}

}
