namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DailyTask
	{
		[ProtoMember(12)] public bool IsFinished;
		[ProtoMember(13)] public int MainMissionId;
	}
	
}
