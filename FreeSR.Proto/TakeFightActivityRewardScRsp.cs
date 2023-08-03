namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakeFightActivityRewardScRsp
	{
		[ProtoMember(10)] public int Retcode;
		[ProtoMember(14)] public ItemList Reward;
		[ProtoMember(12)] public int IFIGMNFCELG;
		[ProtoMember(11)] public int GroupId;
	}
	
}
