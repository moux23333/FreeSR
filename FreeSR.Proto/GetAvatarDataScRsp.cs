namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class GetAvatarDataScRsp
	{
		[ProtoMember(12)] public bool IsAll;
		[ProtoMember(3)] public List<Avatar> AvatarList;
		[ProtoMember(14)] public int Retcode;
	}
	
}
