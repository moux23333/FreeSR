namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Relic
	{
		[ProtoMember(6)] public int BaseAvatarId;
		[ProtoMember(11)] public int Num;
		[ProtoMember(8)] public int UniqueId;
		[ProtoMember(14)] public int Exp;
		[ProtoMember(2)] public int Level;
		[ProtoMember(1)] public int MainAffixId;
		[ProtoMember(10)] public bool IsProtected;
		[ProtoMember(3)] public List<RelicAffix> SubAffixList;
	}
	
}
