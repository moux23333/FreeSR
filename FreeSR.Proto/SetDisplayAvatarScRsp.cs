namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetDisplayAvatarScRsp
	{
		[ProtoMember(14)] public List<GCDGCKFCHFH> DisplayAvatarList;
		[ProtoMember(2)] public int Retcode;
	}
	
}
