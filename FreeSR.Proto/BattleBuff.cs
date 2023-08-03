namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BattleBuff
	{
		[ProtoMember(1)] public int Id;
		[ProtoMember(2)] public int Level;
		[ProtoMember(3)] public int FLCBJGMGPCK;
		[ProtoMember(4)] public int PIBLKBJMJBM;
		[ProtoMember(5)] public List<int> FLNLKCJEBIK;
		[ProtoMember(6)] public Dictionary<string,float> DynamicValues;
	}
	
}
