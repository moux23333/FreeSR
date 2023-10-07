namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TreasureDungeonRecordData
	{
		[ProtoMember(11)] public int TargetGridId;
		[ProtoMember(9)] public int Param1;
		[ProtoMember(6)] public int Param2;
		[ProtoMember(1)] public int SourceGridId;
		[ProtoMember(2)] public KJNHIAKELBF Type;
	}

}
