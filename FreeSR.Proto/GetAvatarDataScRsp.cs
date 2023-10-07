namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAvatarDataScRsp
	{
		[ProtoMember(4)] public bool IsAll;
		[ProtoMember(8)] public List<Avatar> AvatarList;
		[ProtoMember(12)] public int Retcode;
	}

}
