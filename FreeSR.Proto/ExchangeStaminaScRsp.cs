namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class ExchangeStaminaScRsp
	{
		[ProtoMember(14)] public int LastRecoverTime;
		[ProtoMember(8)] public List<ItemCost> ItemCostList;
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(2)] public int ExchangeTimes;
		[ProtoMember(9)] public int StaminaAdd;
	}

}
