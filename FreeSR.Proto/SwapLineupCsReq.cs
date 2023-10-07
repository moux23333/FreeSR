namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SwapLineupCsReq
	{
		[ProtoMember(8)] public int PlaneId;
		[ProtoMember(5)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(3)] public int SrcSlot;
		[ProtoMember(11)] public int DstSlot;
		[ProtoMember(4)] public bool IsVirtual;
		[ProtoMember(13)] public int Index;
	}

}
