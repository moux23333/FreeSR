namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetPlatformPlayerInfoScRsp
	{
		[ProtoMember(7)] public int Retcode;
		[ProtoMember(3)] public List<FKAEABKBFBP> BOFNLAIFJKD;
	}
	
}
