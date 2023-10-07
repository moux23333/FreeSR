namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Relic
	{
		[ProtoMember(5)] public bool IsProtected;
		[ProtoMember(9)] public int UniqueId;
		[ProtoMember(13)] public List<RelicAffix> SubAffixList;
		[ProtoMember(11)] public int Level;
		[ProtoMember(4)] public int Exp;
		[ProtoMember(15)] public int BaseAvatarId;
		[ProtoMember(8)] public int MainAffixId;
		[ProtoMember(2)] public int Tid;
	}

}
