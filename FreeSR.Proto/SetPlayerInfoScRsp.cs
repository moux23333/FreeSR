namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetPlayerInfoScRsp
	{
		[ProtoMember(2)] public long HANDBCAGAJC;
		[ProtoMember(5)] public HeroBasicType CurBasicType;
		[ProtoMember(13)] public int Retcode;
		[ProtoMember(7)] public bool IsModify;
	}
	
}
