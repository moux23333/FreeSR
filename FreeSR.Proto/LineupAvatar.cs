namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LineupAvatar
	{
		[ProtoMember(10)] public int Id;
		[ProtoMember(3)] public AvatarType AvatarType;
		[ProtoMember(8)] public int Sp;
		[ProtoMember(5)] public int Satiety;
		[ProtoMember(13)] public int Slot;
		[ProtoMember(11)] public int Hp;
	}
	
}
