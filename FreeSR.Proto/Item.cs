namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Item
	{
		[ProtoMember(11)] public int Num;
		[ProtoMember(13)] public int ItemId;
		[ProtoMember(4)] public int Level;
		[ProtoMember(15)] public int MainAffixId;
		[ProtoMember(1)] public int UniqueId;
		[ProtoMember(2)] public int Promotion;
		[ProtoMember(5)] public int Rank;
	}
	
}
