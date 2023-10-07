namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class EquipmentProperty
	{
		[ProtoMember(1)] public int Id;
		[ProtoMember(2)] public int Rank;
		[ProtoMember(3)] public int Promotion;
		[ProtoMember(4)] public int Level;
	}

}
