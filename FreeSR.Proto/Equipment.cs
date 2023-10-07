namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Equipment
	{
		[ProtoMember(9)] public int Level;
		[ProtoMember(5)] public int BaseAvatarId;
		[ProtoMember(4)] public int UniqueId;
		[ProtoMember(6)] public int Tid;
		[ProtoMember(2)] public int Promotion;
		[ProtoMember(7)] public int Exp;
		[ProtoMember(12)] public bool IsProtected;
		[ProtoMember(11)] public int Rank;
	}

}
