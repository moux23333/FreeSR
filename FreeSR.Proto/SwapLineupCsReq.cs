namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SwapLineupCsReq
	{
		[ProtoMember(9)] public int DstSlot;
		[ProtoMember(11)] public int PlaneId;
		[ProtoMember(15)] public int Index;
		[ProtoMember(12)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(6)] public int SrcSlot;
		[ProtoMember(3)] public bool IsVirtual;
	}
	
}
