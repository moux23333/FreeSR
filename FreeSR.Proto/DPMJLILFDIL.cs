namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DPMJLILFDIL
	{
		[ProtoMember(12)] public int Num;
		[ProtoMember(14)] public int Promotion;
		[ProtoMember(8)] public int Rank;
		[ProtoMember(15)] public int Level;
		[ProtoMember(1)] public int Exp;
	}
	
}
