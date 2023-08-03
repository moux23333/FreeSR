namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAllSaveRaidScRsp
	{
		[ProtoMember(14)] public List<HFPMBAMDAMF> AALMCFAAONN;
		[ProtoMember(11)] public int Retcode;
	}
	
}
