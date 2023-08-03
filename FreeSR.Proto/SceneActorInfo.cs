namespace FreeSR.Proto
{
	using ProtoBuf;

	[ProtoContract]
	public class SceneActorInfo
	{
		[ProtoMember(11)] public int BaseAvatarId;
		[ProtoMember(14)] public int MapLayer;
		[ProtoMember(3)] public int Uid;
		[ProtoMember(12)] public AvatarType AvatarType;
	}
	
}
