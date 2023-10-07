namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LineupAvatar
	{
		[ProtoMember(2)] public HealthBarInfo CurHealth;
		[ProtoMember(10)] public int Id;
		[ProtoMember(7)] public int Slot;
		[ProtoMember(8)] public AvatarType AvatarType;
		[ProtoMember(9)] public int Sp;
		[ProtoMember(13)] public int Satiety;
	}

}
