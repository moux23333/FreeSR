namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LineupSlotData
	{
		[ProtoMember(14)] public int Slot;
		[ProtoMember(13)] public AvatarType AvatarType;
		[ProtoMember(11)] public int Id;
	}

}
