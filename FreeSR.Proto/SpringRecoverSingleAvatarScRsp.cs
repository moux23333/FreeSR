namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringRecoverSingleAvatarScRsp
	{
		[ProtoMember(4)] public AvatarType AvatarType;
		[ProtoMember(12)] public int Id;
		[ProtoMember(8)] public int Retcode;
		[ProtoMember(14)] public int Hp;
	}
	
}
