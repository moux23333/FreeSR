namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DailyTaskDataScNotify
	{
		[ProtoMember(5)] public List<DailyTask> DailyTaskList;
		[ProtoMember(12)] public int FinishedNum;
	}
	
}
