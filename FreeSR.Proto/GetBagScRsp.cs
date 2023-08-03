namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetBagScRsp
	{
		[ProtoMember(10)] public List<int> MIBKDFMMOBC;
		[ProtoMember(1)] public List<Material> MaterialList;
		[ProtoMember(2)] public List<WaitDelResource> WaitDelResourceList;
		[ProtoMember(14)] public int Retcode;
		[ProtoMember(7)] public List<Relic> RelicList;
		[ProtoMember(6)] public List<Equipment> EquipmentList;
		[ProtoMember(5)] public List<KEKDHAJGLOO> LBLLFKHJGEE;
		[ProtoMember(11)] public List<KEKDHAJGLOO> ALAEMNLAPHJ;
		[ProtoMember(15)] public List<Material> RogueItemList;
	}
	
}
