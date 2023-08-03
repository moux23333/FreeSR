namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LineupAvatarData
	{
		[ProtoMember(9)] public int Hp;
		[ProtoMember(4)] public AvatarType AvatarType;
		[ProtoMember(7)] public int Id;
	}
	
}
