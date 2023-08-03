namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class BoxingClubRewardScNotify
	{
		[ProtoMember(5)] public int LHJEHADAMDI;
		[ProtoMember(7)] public ItemList Reward;
		[ProtoMember(13)] public int ChallengeId;
		[ProtoMember(9)] public bool IsWin;
	}
	
}
