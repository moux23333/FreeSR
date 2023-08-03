namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExchangeStaminaScRsp
	{
		[ProtoMember(13)] public List<ItemCost> ItemCostList;
		[ProtoMember(2)] public int StaminaAdd;
		[ProtoMember(3)] public int ExchangeTimes;
		[ProtoMember(11)] public int Retcode;
		[ProtoMember(10)] public long LastRecoverTime;
	}
	
}
