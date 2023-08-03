namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeAllApRewardScRsp
	{
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(3)] public List<int> BCIEGKCHOIK;
		[ProtoMember(5)] public ItemList Reward;
	}
	
}
