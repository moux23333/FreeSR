namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeTalkRewardScRsp
	{
		[ProtoMember(6)] public int TalkEventId;
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(14)] public ItemList Reward;
	}
	
}
