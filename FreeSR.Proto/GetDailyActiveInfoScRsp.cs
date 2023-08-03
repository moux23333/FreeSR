namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetDailyActiveInfoScRsp
	{
		[ProtoMember(4)] public List<int> DailyActiveQuestIdList;
		[ProtoMember(9)] public int Retcode;
		[ProtoMember(15)] public int DailyActivePoint;
		[ProtoMember(1)] public List<BAPMEKJDPIC> DailyActiveLevelList;
	}
	
}
