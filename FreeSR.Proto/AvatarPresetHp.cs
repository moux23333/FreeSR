namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class AvatarPresetHp
	{
		[ProtoMember(10)] public int PresetHp;
		[ProtoMember(14)] public int AvatarId;
	}
	
}
