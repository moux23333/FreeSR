namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FNFLOGCKIAH
	{
		[ProtoMember(15)] public int Exp;
		[ProtoMember(11)] public int Promotion;
		[ProtoMember(13)] public int Level;
		[ProtoMember(8)] public int Tid;
		[ProtoMember(2)] public int Rank;
	}

}
