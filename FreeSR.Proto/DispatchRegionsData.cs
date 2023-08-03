namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DispatchRegionsData
	{
		[ProtoMember(1)] public int Retcode;
		[ProtoMember(2)] public string Msg;
		[ProtoMember(3)] public string TopSeverRegionName;
		[ProtoMember(4)] public List<RegionEntry> RegionList;
		[ProtoMember(5)] public string StopDesc;
	}
	
}
