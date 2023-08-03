namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeApRewardScRsp
	{
		[ProtoMember(12)] public ItemList Reward;
		[ProtoMember(10)] public int Level;
		[ProtoMember(4)] public int Retcode;
	}
	
}
