namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ChallengeSettleNotify
	{
		[ProtoMember(6)] public int Stars;
		[ProtoMember(12)] public ItemList Reward;
		[ProtoMember(11)] public int ChallengeId;
		[ProtoMember(8)] public bool IsWin;
	}
	
}
