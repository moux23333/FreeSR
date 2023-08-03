namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetNicknameScRsp
	{
		[ProtoMember(15)] public int Retcode;
		[ProtoMember(1)] public bool IsModify;
		[ProtoMember(13)] public long HANDBCAGAJC;
	}
	
}
