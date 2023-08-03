namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TreasureDungeonRecordData
	{
		[ProtoMember(1)] public int Param2;
		[ProtoMember(8)] public int TargetGridId;
		[ProtoMember(6)] public MMDLIPGBPFN Type;
		[ProtoMember(3)] public int Param1;
		[ProtoMember(5)] public int SourceGridId;
	}
	
}
