namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Equipment
	{
		[ProtoMember(9)] public int Rank;
		[ProtoMember(10)] public int Level;
		[ProtoMember(13)] public bool IsProtected;
		[ProtoMember(11)] public int UniqueId;
		[ProtoMember(2)] public int Exp;
		[ProtoMember(1)] public int BaseAvatarId;
		[ProtoMember(3)] public int Promotion;
		[ProtoMember(4)] public int Tid;
	}
	
}
