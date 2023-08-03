namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class DoGachaScRsp
	{
		[ProtoMember(5)] public int CEHNPOHELMK;
		[ProtoMember(11)] public int BBGOINCNNOB;
		[ProtoMember(14)] public int EIMEBOGAEIJ;
		[ProtoMember(10)] public int GachaNum;
		[ProtoMember(3)] public int GachaId;
		[ProtoMember(2)] public int DOPEBAALINP;
		[ProtoMember(4)] public int BJMOFAAAFGM;
		[ProtoMember(1)] public List<GachaItem> GachaItemList;
		[ProtoMember(13)] public int Retcode;
	}
	
}
