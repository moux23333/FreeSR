namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SetDisplayAvatarCsReq
	{
		[ProtoMember(14)] public List<GCDGCKFCHFH> DisplayAvatarList;
	}
	
}
