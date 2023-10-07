namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringRecoverSingleAvatarScRsp
	{
		[ProtoMember(1)] public AvatarType AvatarType;
		[ProtoMember(9)] public int Hp;
		[ProtoMember(4)] public int Retcode;
		[ProtoMember(12)] public int Id;
	}

}
