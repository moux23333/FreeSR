namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SpringRecoverConfig
	{
		[ProtoMember(9)] public bool AutoRecoverHp;
		[ProtoMember(8)] public List<AvatarPresetHp> AvatarPresetHpList;
		[ProtoMember(11)] public int DefaultHp;
	}
	
}
