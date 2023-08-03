namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class HPDIBDEACLC
	{
		[ProtoMember(1)] public int MainAffixId;
		[ProtoMember(8)] public List<RelicAffix> SubAffixList;
		[ProtoMember(13)] public int Type;
		[ProtoMember(4)] public int Num;
		[ProtoMember(2)] public int Exp;
		[ProtoMember(3)] public int Level;
	}
	
}
