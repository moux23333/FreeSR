namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FightActivityGroup
	{
		[ProtoMember(8)] public List<int> TakenDifficultyLevelRewardList;
		[ProtoMember(13)] public int GroupId;
		[ProtoMember(15)] public int PassedMaxDifficultyLevel;
		[ProtoMember(7)] public int EndlessMaxWave;
	}

}
