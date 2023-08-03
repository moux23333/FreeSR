namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class Quest
	{
		[ProtoMember(7)] public int Progress;
		[ProtoMember(12)] public long FinishTime;
		[ProtoMember(3)] public int Id;
		[ProtoMember(8)] public QuestStatus Status;
		[ProtoMember(9)] public List<int> AGIALDJABFM;
	}
	
}
