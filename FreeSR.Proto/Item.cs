namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Item
	{
		[ProtoMember(9)] public int Level;
		[ProtoMember(2)] public int UniqueId;
		[ProtoMember(8)] public int ItemId;
		[ProtoMember(6)] public int Promotion;
		[ProtoMember(14)] public int Rank;
		[ProtoMember(12)] public int Num;
		[ProtoMember(7)] public int MainAffixId;
	}

}
