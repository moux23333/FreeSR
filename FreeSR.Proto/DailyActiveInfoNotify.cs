namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DailyActiveInfoNotify
	{
		[ProtoMember(8)] public List<BAPMEKJDPIC> DailyActiveLevelList;
		[ProtoMember(13)] public List<int> DailyActiveQuestIdList;
		[ProtoMember(3)] public int DailyActivePoint;
	}
	
}
