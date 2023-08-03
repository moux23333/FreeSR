namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class LineupInfo
	{
		[ProtoMember(15)] public int AMBCECDBHFC;
		[ProtoMember(5)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(13)] public string Name;
		[ProtoMember(1)] public int Index;
		[ProtoMember(6)] public List<LineupAvatar> AvatarList;
		[ProtoMember(2)] public bool IsVirtual;
		[ProtoMember(9)] public int PlaneId;
		[ProtoMember(4)] public int EDPAHDAAGIK;
		[ProtoMember(14)] public int LeaderSlot;
	}
	
}
