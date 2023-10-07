namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class PMNHNDIHGNJ
	{
		[ProtoMember(7)] public int Tid;
		[ProtoMember(10)] public int Exp;
		[ProtoMember(2)] public int Level;
		[ProtoMember(4)] public int Promotion;
		[ProtoMember(5)] public int Rank;
	}

}
