namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PBLJOANMLIP
	{
		[ProtoMember(3)] public int Level;
		[ProtoMember(11)] public int Exp;
		[ProtoMember(10)] public int Num;
		[ProtoMember(15)] public int MainAffixId;
		[ProtoMember(13)] public List<RelicAffix> SubAffixList;
	}
	
}
