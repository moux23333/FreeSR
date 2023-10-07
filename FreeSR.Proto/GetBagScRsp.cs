namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetBagScRsp
	{
		[ProtoMember(3)] public int Retcode;
		[ProtoMember(6)] public List<JAKOAONFNGN> Lkgomebojaf;
		[ProtoMember(7)] public List<Relic> RelicList;
		[ProtoMember(13)] public List<Material> Eangcgpdmbm;
		[ProtoMember(8)] public List<int> Fccfaphdpib;
		[ProtoMember(1)] public List<Material> MaterialList;
		[ProtoMember(9)] public List<WaitDelResource> WaitDelResourceList;
		[ProtoMember(14)] public int Agdpohepddk;
		[ProtoMember(11)] public List<JAKOAONFNGN> Kpbmgjkokda;
		[ProtoMember(2)] public List<Equipment> EquipmentList;
	}

}
