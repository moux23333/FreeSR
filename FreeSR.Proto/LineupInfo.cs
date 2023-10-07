namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LineupInfo
	{
		[ProtoMember(5)] public int Index;
		[ProtoMember(10)] public int PlaneId;
		[ProtoMember(9)] public List<LineupAvatar> AvatarList;
		[ProtoMember(14)] public bool IsVirtual;
		[ProtoMember(8)] public int Foafdgjflmc;
		[ProtoMember(3)] public string Name;
		[ProtoMember(2)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(12)] public int Gfefibheegh;
		[ProtoMember(6)] public int LeaderSlot;
	}

}
