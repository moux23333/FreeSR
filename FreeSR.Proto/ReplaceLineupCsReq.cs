namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ReplaceLineupCsReq
	{
		[ProtoMember(3)] public int Index;
		[ProtoMember(11)] public bool IsVirtual;
		[ProtoMember(7)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(13)] public List<LineupSlotData> Slots;
		[ProtoMember(10)] public int PlaneId;
		[ProtoMember(5)] public int Gfefibheegh;
	}

}
