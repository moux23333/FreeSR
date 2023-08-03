namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class TakePunkLordPointRewardScRsp
	{
		[ProtoMember(10)] public ItemList Reward;
		[ProtoMember(11)] public bool FFEPMJNBFJN;
		[ProtoMember(14)] public int Level;
		[ProtoMember(12)] public int Retcode;
	}
	
}
