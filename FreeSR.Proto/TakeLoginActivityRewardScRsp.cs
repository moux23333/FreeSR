namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeLoginActivityRewardScRsp
	{
		[ProtoMember(15)] public int Retcode;
		[ProtoMember(3)] public ItemList Reward;
		[ProtoMember(8)] public int TakeDays;
		[ProtoMember(5)] public int Id;
	}
	
}
