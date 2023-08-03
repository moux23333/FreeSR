namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeChallengeRewardScRsp
	{
		[ProtoMember(13)] public ItemList Reward;
		[ProtoMember(1)] public int DIMJKAICMDD;
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(9)] public int GroupId;
	}
	
}
