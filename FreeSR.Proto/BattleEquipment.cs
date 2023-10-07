namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleEquipment
	{
		[ProtoMember(1)] public int Id;
		[ProtoMember(2)] public int Level;
		[ProtoMember(3)] public int Promotion;
		[ProtoMember(4)] public int Rank;
	}

}
