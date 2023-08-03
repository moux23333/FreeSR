namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class FightActivityGroup
	{
		[ProtoMember(6)] public int PassedMaxDifficultyLevel;
		[ProtoMember(5)] public List<int> TakenDifficultyLevelRewardList;
		[ProtoMember(8)] public int EndlessMaxWave;
		[ProtoMember(2)] public int GroupId;
	}
	
}
