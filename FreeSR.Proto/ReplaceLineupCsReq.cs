namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ReplaceLineupCsReq
	{
		[ProtoMember(13)] public bool IsVirtual;
		[ProtoMember(9)] public int EDPAHDAAGIK;
		[ProtoMember(15)] public int PlaneId;
		[ProtoMember(10)] public int Index;
		[ProtoMember(7)] public ExtraLineupType ExtraLineupType;
		[ProtoMember(12)] public List<EDFALKDIGGP> ABCLOBIAPPL;
	}
	
}
