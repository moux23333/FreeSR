namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetQuestDataScRsp
	{
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(1)] public List<Quest> QuestList;
		[ProtoMember(13)] public int TotalAchievementExp;
	}
	
}
